namespace Roboterwelt_VLG
{
    class Walkscript
    {
        public void interprete(Roboter r, string instructions)
        {
            instructions = instructions.ToLower();

            for (int i = 0; i < instructions.Length; i++)
            {
                if (isNumber(instructions[i]))
                {
                    for (int j = 0; j < instructions[i] - 48; j++)
                    {
                        selectAction(r, instructions[i + 1]);
                    }
                }
                else
                {
                    selectAction(r, instructions[i]);
                }
            }
        }

        bool isNumber(char c)
        { return c >= 48 && c <= 57; }

        void selectAction(Roboter r, char c)
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
    }
}