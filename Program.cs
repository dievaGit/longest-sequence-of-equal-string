using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, m = 0;

            do
            {
                Console.WriteLine(" Write the number of row greater than 2:");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 2);

            do
            {
                Console.WriteLine(" Write the number of columns greater than 2:");
                m = Convert.ToInt32(Console.ReadLine());
            }
            while (m < 2);

            string[,] matrix = new string[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(" Write one word:");
                    matrix[i, j] = Console.ReadLine();
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.Write(" \n");
            }
            Console.Write(" \n");

            string cad = "";
            string cadAux = "";
            
            
            //horizontal search
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < m - 1; j ++)
                {
                    
                    if (matrix[i,j] == matrix[i,j + 1])
                    {
                        if(cadAux == "")
                        {
                            cadAux = cadAux + "," + matrix[i, j];
                            cadAux = cadAux + ", " + matrix[i, j + 1];
                        }
                        else
                        {
                            cadAux = matrix[i, j + 1];
                        }
                        
                    }
                    
                     
                    if(cad.Length < cadAux.Length)
                    {
                            cad = cadAux;
                            cadAux = "";
                    }
                    
                    
                }
                cadAux = "";
                
            }

            //vertical search
            for (int j = 0; j < m; j++)
            {
                
                for (int i = 0; i < n - 1; i++)
                {
                    
                    if (matrix[i, j] == matrix[i+ 1, j])
                    {
                        if (cadAux == "")
                        {
                            cadAux = cadAux + "," + matrix[i, j];
                            cadAux = cadAux + ", " + matrix[i + 1, j];
                        }
                        else
                        {
                            cadAux = matrix[i + 1, j];
                        }
                        
                    }
                    
                    
                    if (cad.Length < cadAux.Length)
                    {
                            cad = cadAux;
                            cadAux = "";
                    }
                    

                }
                cadAux = "";

            }

            //Diagonal seach
            for (int j = 0; j < n; j++)
            {
                
                for (int i = n-2; i <=0; i--)
                {
                    while(i<n || j < n)
                    {
                        if (matrix[i, j] == matrix[i + 1, j + 1])
                        {
                            if (cadAux == "")
                            {
                                cadAux = cadAux + "," + matrix[i, j];
                                cadAux = cadAux + ", " + matrix[i + 1, j + 1];
                            }
                            else
                            {
                                cadAux = matrix[i + 1, j + 1];
                            }


                        }
                        else
                        {

                            if (cad.Length < cadAux.Length)
                            {
                                cad = cadAux;
                                cadAux = "";
                            }
                        }
                    }
                   

                }
                cadAux = "";

            }
                      
            Console.WriteLine(" The longest sequence of equal string are: " + cad);

            Console.ReadKey();
        }
    }
}
