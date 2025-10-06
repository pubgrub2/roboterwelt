using System.Drawing.Text;
using System.Windows.Forms;

namespace Roboterwelt_VLG
{
    class Walkscript
    {
        public void Interprete(Roboter r, string inst)
        {
            inst = inst.ToLower();

            for (int i = 0; i < inst.Length; i++)
            {
                int multiplier = 1;
                if (IsNumber(inst[i]))
                {
                    //for (int j = 0; j < inst[i] - 48; j++)
                    //{
                    //    SelectAction(r, inst[i + 1]);
                    //}
                    (int newMultiplier, int j) = SingleNumbersToInt(inst, i);
                    i += j;
                    multiplier = newMultiplier;
                }


                if (inst[i] == '(')
                {
                    GetLoop(inst, i);
                }





                
                else
                {
                    SelectAction(r, inst[i]);
                }


            }
        }

        bool IsNumber(char c)
        { return c >= 48 && c <= 57; }

        void SelectAction(Roboter r, char c)
        {
            switch(c)
            {
                case 'w': r.schritt(); break;
                case 'a': r.dreheLinks(); break;
                case 'd': r.dreheRechts(); break;
                case 's': r.umdrehen(); break;
                case 'q': r.aufheben(); break;
                case 'e': r.ablegen(); break;

            }
        }

        string GetLoop(string inst, int i)
        {
            
            
            int j = 1;
            string loopedInst = null;
            while (inst[i + j] != ')')
            {
                loopedInst += inst[i + j];
                j++;
            }
            return loopedInst;
                //if (inst[i + j] == ')')
                //{
                //    i = i + j;
                //    for (int k = 0; k < loopedInst.Length; k++)
                //    {
                //        selectAction(r, loopedInst[k]);
                //    }
                //}
            
        }

        (int, int) SingleNumbersToInt(string inst, int i)
        {
            int j = 0;
            string numberString = null;
            while (IsNumber(inst[i + j]))
            {
                numberString += inst[i + j];
                j++;
            }

            return (int.Parse(numberString), j);
            
        }
        
    }
}