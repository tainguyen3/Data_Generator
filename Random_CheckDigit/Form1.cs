using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_CheckDigit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_Generator_Click(object sender, EventArgs e){
            var path = @"D:\output.txt";
            string outputData = "";
            Random_Characters Random_char = new Random_Characters();
            Code128_C C128_C = new Code128_C();
            int data_rd, data_length;
            string data;
            /* Create a random C128 data*/
            loop:
            data_rd = Random_char.Random_Number(System.Convert.ToDouble(tb_Data.Text));
            data = System.Convert.ToString(data_rd);
            data_length = data.Length;
            if (data_length % 2 != 0) { 
                goto loop;
            }
            /* Calculate Check Digit */
            int CD_128C = C128_C.CheckDigit(data);            
            /* Create new data */
                 for (int rd_data = 10; rd_data < Math.Pow(10,data_length); rd_data++) { 
                    if( (Math.Sqrt(rd_data) % 10 == 0) ){
                        rd_data *= 10;
                    }
                    /* Choose position to insert random data */
                    for (int position = 0; position < data_length; position++){
                        string new_data;
                        /* Concat new string of data */
                        string part1 = data.Substring(0, position);
                        string part2 = data.Substring(position, (data_length - position));
                        new_data = String.Concat(part1, rd_data, part2);
                        //if(position % 2 == 0) { 
                            /* Calculate Check Digit of new string */
                            int CD_new_data = C128_C.CheckDigit(new_data);
                            /* Save new data if new Check Digit = Check Digit of input data */
                            if (CD_new_data == CD_128C){
                                    outputData += 
                                       "\nData       : " + data     +
                                       "\nInsert Data: " + rd_data  +
                                       "\nPosition   : " + position +
                                       "\nNew data   : " + new_data +
                                       "\nCD         : " + CD_128C  + "\n";
                      //      }
                        }
                    }
                 }
        File.WriteAllText(path, outputData);
        }
    }
}
