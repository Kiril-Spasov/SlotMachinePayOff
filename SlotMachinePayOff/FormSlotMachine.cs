using System;
using System.IO;
using System.Windows.Forms;

namespace SlotMachinePayOff
{
    public partial class FormSlotMachine : Form
    {
        public FormSlotMachine()
        {
            InitializeComponent();
        }

        int gains = 0;

        private void BtnDisplayResults_Click(object sender, EventArgs e)
        {
            int wheel1, wheel2, wheel3;

            string path = Application.StartupPath + @"\slots.txt";
            StreamReader streamReader = new StreamReader(path);

            wheel1 = Convert.ToInt32(streamReader.ReadLine());
            wheel2 = Convert.ToInt32(streamReader.ReadLine());
            wheel3 = Convert.ToInt32(streamReader.ReadLine());

            TxtResult.Text += "DIAL NUMBERS \t         GAIN/LOSS    OUTCOME" + Environment.NewLine;
            CalculatePayOff(wheel1, wheel2, wheel3);

        }

        private void CalculatePayOff(int wheel1, int wheel2, int wheel3)
        {
            int multiplierWheel2 = 0;
            int multiplierWheel3 = 0;

            int resultWheel1;
            int resultWheel2;
            int resultWheel3;

            for (int i = 1; i <= 21; i++)
            {
                gains -= 25;

                TxtResult.Text += DisplayText(wheel1, wheel2, wheel3);

                //We find how many times the first wheel reached 10. Those are the times the second wheel made 7 advances.
                //Then we find how many times the second wheel reach 10. Those are the times the third wheel made 1 advance.
                //We find where each wheel stopped by finding the reminder of 10 from the total advances.
                multiplierWheel2 = (wheel1 + 23) / 10;
                resultWheel1 = (wheel1 + 23) % 10;
                wheel1 = resultWheel1;

                multiplierWheel3 = (wheel2 + (7 * multiplierWheel2)) / 10;
                resultWheel2 = (wheel2 + (7 * multiplierWheel2)) % 10;
                wheel2 = resultWheel2;

                resultWheel3 = (wheel3 + (1 * multiplierWheel3)) % 10;
                wheel3 = resultWheel3;
            }
        }

        private string DisplayText(int score1, int score2, int score3)
        {
            string display = "";

            display += score1 + "\t" + score2 + "\t" + score3;

            if (score1 == score2 && score2 == score3)
            {
                gains += 500;
                display += "\t" + gains + "\t JACKPOT" + Environment.NewLine;
            }
            else if (score1 == score2 || score1 == score3 || score2 == score3)
            {
                gains += 100;
                display += "\t" + gains + "\t BONUS" + Environment.NewLine;
            }
            else
            {
                display += "\t" + gains + Environment.NewLine;
            }

            return display;
        }
    }
}
