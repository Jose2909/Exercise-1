using System;
using System.Text.RegularExpressions;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
                Program comp = new Program();
                Console.WriteLine("StringComparison()\n");
                Console.WriteLine(comp.comparacion("Nanapancha", "Nanapancha"));


                Program bigNum = new Program();
                int[] lista = new int[] { -4, -1, -7, -3, -4 };
                Console.WriteLine("VerifyBiggestNumber()\n");
                bigNum.biggestNumber(lista);


                Program asDes = new Program();
                String[] listString = new String[] { "German", "Ana", "Padalustro", "America", "Daniel", "Braulio", "Ana", "Camilo", "Gerardo", "Fernando" };
                Console.WriteLine("\tSortList()\n");
                Console.WriteLine("\tOriginal List\n");
                foreach (String lisShow in listString){
                Console.WriteLine("\t" + lisShow );
                }
                Console.WriteLine("\n");
                asDes.sortingAscDesc(listString);


                Program cuentaChar = new Program();
                Console.WriteLine("CountStringLength()\n");
                Console.WriteLine(cuentaChar.cuentaCaracts("Algun String para Calar"));

        }

        public String comparacion(String word1, String word2)
        {
            try
            {     
                
                if (word1.Equals(word2))
                {

                    return "Both Strings are equals. \n";
                }
                else
                {

                    return "The strings are not equals.";
                }
                
            }
            catch (Exception e)
            {
                return "Must enter a value";
            }
        }


        public void biggestNumber(int[] list)
        {
           
            int conteo = 0;
            for (int intmay = 0; intmay < list.Length; intmay++)
            {
                for (int intmay2 = 0; intmay2 < list.Length && intmay != intmay2; intmay2++)
                {
                    if (list[intmay] < (list[intmay2]))
                    {
                        int intaux = list[intmay];
                        list[intmay] = list[intmay2];
                        list[intmay2] = intaux;

                    }
                }
                conteo++;
            }
            Console.WriteLine("El numero mayor es : " + list[conteo - 1] +"\t");
           
         }


        public void sortingAscDesc(String[] strgList)
        {
            Console.WriteLine("\tAscending :\n");
            for (int strasc = 0; strasc < strgList.Length; strasc++)
            {
                for (int strasc2 = 0; strasc2 < strgList.Length && strasc != strasc2; strasc2++)
                {
                    if (strgList[strasc].CompareTo(strgList[strasc2]) < 0)
                    {
                        String auxiliar = strgList[strasc];
                        strgList[strasc] = strgList[strasc2];
                        strgList[strasc2] = auxiliar;
                    }
                }
            }
            foreach (String show in strgList)
                Console.WriteLine("\t" + show);

            Console.WriteLine("Descending :\t\n");
            for (int strdesc = 0; strdesc < strgList.Length; strdesc++)
            {
                for (int strdesc2 = 0; strdesc2 < strgList.Length && strdesc != strdesc2; strdesc2++)
                {
                    if (strgList[strdesc].CompareTo(strgList[strdesc2]) > 0)
                    {
                        String auxiliar2 = strgList[strdesc2];
                        strgList[strdesc2] = strgList[strdesc];
                        strgList[strdesc] = auxiliar2;
                    }
                }
            }
            foreach (String showdesc in strgList)
            {
                Console.WriteLine(showdesc);
            }
        }


        public int cuentaCaracts(String strg1)
        {
            int count = 0;
            
            foreach (char cuenta in strg1.ToCharArray())
            {
                count++;
                Console.WriteLine("\t The characters are: " + cuenta);
            }
            Console.WriteLine("\t\n Total Characters ");
            return count;
        }
    }
}