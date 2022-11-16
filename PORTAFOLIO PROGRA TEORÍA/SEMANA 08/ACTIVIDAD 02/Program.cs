// See https://aka.ms/new-console-template for more information

Console.WriteLine("Buenos días, ingrese 10 palabras en el siguiente espacio:");
string P1 = Console.ReadLine();
string P2 = Console.ReadLine();
string P3 = Console.ReadLine();
string P4 = Console.ReadLine();
string P5 = Console.ReadLine();
string P6 = Console.ReadLine();
string P7 = Console.ReadLine();
string P8 = Console.ReadLine();
string P9 = Console.ReadLine();
string P10 = Console.ReadLine();
string A1, A2, A3, A4, A5, A6, A7, A8, A9, A10;
int j1, j2, j3, j4, j5, j6, j7, j8, j9, j10;
int l1, l2, l3, l4, l5, l6, l7, l8, l9, l10;
char i1, i2, i3, i4, i5, i6, i7, i8, i9, i10;
char m1, m2, m3, m4, m5, m6, m7, m8, m9, m10;
int E1 = 0;
int E2 = 0;
int E3 = 0;
int E4 = 0;
int E5 = 0;
int E6 = 0;
int E7 = 0;
int E8 = 0;
int E9 = 0;
int E10 = 0;
int M1 = 0;
int M2 = 0;
int M3 = 0;
int M4 = 0;
int M5 = 0;
int M6 = 0;
int M7 = 0;
int M8 = 0;
int M9 = 0;
int M10 = 0;


A1 = P1.ToUpper();
if (A1 == P1)
{
    Console.WriteLine("La palabra " + P1 + " es una palabra molesta");
}
else
    for (j1 = 0; j1 < P1.Length; j1++)
    {
        i1 = P1[j1];
        int c1 = char.ToLower(i1);
        if ((c1 == '!') | (c1 == '¡'))
        {
            E1++;
        }
        else
            for (l1 = 0; l1 < P1.Length; l1++)
            {
                m1 = P1[l1];
                int k1 = char.ToLower(m1);
                if ((k1 == '?') | (k1 == '¿')) ;
                {
                    M1++;
                }
            }
        if (E1 >= 2)
        {
            Console.WriteLine("La palabra " + P1 + " es una palabra molesta");
        }
        else if (M1 >= 2)
        {
            Console.WriteLine("La palabra " + P1 + " es una palabra molesta");
        }
        else
        {
            Console.WriteLine("La palabra " + P1 + " no es una palabra molesta");
        }

        A2 = P2.ToUpper();
        if (A2 == P2)
        {
            Console.WriteLine("La palabra " + P2 + " es una palabra molesta");
        }
        else
            for (j2 = 0; j2 < P2.Length; j2++)
            {
                i2 = P2[j2];
                int c2 = char.ToLower(i2);
                if ((c2 == '!') | (c2 == '¡'))
                {
                    E2++;
                }
                else
                    for (l2 = 0; l2 < P2.Length; l2++)
                    {
                        m2 = P2[l2];
                        int k2 = char.ToLower(m2);
                        if ((k2 == '?') | (k2 == '¿')) ;
                        {
                            M2++;
                        }
                    }
                if (E2 >= 2)
                {
                    Console.WriteLine("La palabra " + P2 + " es una palabra molesta");
                }
                else if (M2 >= 2)
                {
                    Console.WriteLine("La palabra " + P2 + " es una palabra molesta");
                }
                else
                {
                    Console.WriteLine("La palabra " + P2 + " no es una palabra molesta");
                }


                A3 = P3.ToUpper();
                if (A3 == P3)
                {
                    Console.WriteLine("La palabra " + P3 + " es una palabra molesta");
                }
                else
                    for (j3 = 0; j3 < P3.Length; j3++)
                    {
                        i3 = P3[j3];
                        int c3 = char.ToLower(i3);
                        if ((c3 == '!') | (c3 == '¡'))
                        {
                            E3++;
                        }
                        else
                            for (l3 = 0; l3 < P3.Length; l3++)
                            {
                                m3 = P3[l3];
                                int k3 = char.ToLower(m3);
                                if ((k3 == '?') | (k3 == '¿')) ;
                                {
                                    M3++;
                                }
                            }
                        if (E3 >= 2)
                        {
                            Console.WriteLine("La palabra " + P3 + " es una palabra molesta");
                        }
                        else if (M3 >= 2)
                        {
                            Console.WriteLine("La palabra " + P3 + " es una palabra molesta");
                        }
                        else
                        {
                            Console.WriteLine("La palabra " + P3 + " no es una palabra molesta");
                        }

                        A4 = P4.ToUpper();
                        if (A4 == P4)
                        {
                            Console.WriteLine("La palabra " + P4 + " es una palabra molesta");
                        }
                        else
                            for (j4 = 0; j4 < P4.Length; j4++)
                            {
                                i4 = P4[j4];
                                int c4 = char.ToLower(i4);
                                if ((c4 == '!') | (c4 == '¡'))
                                {
                                    E4++;
                                }
                                else
                                    for (l4 = 0; l4 < P4.Length; l4++)
                                    {
                                        m4 = P4[l4];
                                        int k4 = char.ToLower(m4);
                                        if ((k4 == '?') | (k4 == '¿')) ;
                                        {
                                            M4++;
                                        }
                                    }
                                if (E4 >= 2)
                                {
                                    Console.WriteLine("La palabra " + P4 + " es una palabra molesta");
                                }
                                else if (M4 >= 2)
                                {
                                    Console.WriteLine("La palabra " + P4 + " es una palabra molesta");
                                }
                                else
                                {
                                    Console.WriteLine("La palabra " + P4 + " no es una palabra molesta");
                                }


                                A5 = P5.ToUpper();
                                if (A5 == P5)
                                {
                                    Console.WriteLine("La palabra " + P5 + " es una palabra molesta");
                                }
                                else
                                    for (j5 = 0; j5 < P5.Length; j5++)
                                    {
                                        i5 = P5[j5];
                                        int c5 = char.ToLower(i5);
                                        if ((c5 == '!') | (c5 == '¡'))
                                        {
                                            E5++;
                                        }
                                        else
                                            for (l5 = 0; l5 < P5.Length; l5++)
                                            {
                                                m5 = P5[l5];
                                                int k5 = char.ToLower(m5);
                                                if ((k5 == '?') | (k5 == '¿')) ;
                                                {
                                                    M5++;
                                                }
                                            }
                                        if (E5 >= 2)
                                        {
                                            Console.WriteLine("La palabra " + P5 + " es una palabra molesta");
                                        }
                                        else if (M5 >= 2)
                                        {
                                            Console.WriteLine("La palabra " + P5 + " es una palabra molesta");
                                        }
                                        else
                                        {
                                            Console.WriteLine("La palabra " + P5 + " no es una palabra molesta");
                                        }


                                        A6 = P6.ToUpper();
                                        if (A6 == P6)
                                        {
                                            Console.WriteLine("La palabra " + P6 + " es una palabra molesta");
                                        }
                                        else
                                            for (j6 = 0; j6 < P6.Length; j6++)
                                            {
                                                i6 = P6[j6];
                                                int c6 = char.ToLower(i6);
                                                if ((c6 == '!') | (c6 == '¡'))
                                                {
                                                    E6++;
                                                }
                                                else
                                                    for (l6 = 0; l6 < P6.Length; l6++)
                                                    {
                                                        m6 = P6[l6];
                                                        int k6 = char.ToLower(m6);
                                                        if ((k6 == '?') | (k6 == '¿')) ;
                                                        {
                                                            M6++;
                                                        }
                                                    }
                                                if (E6 >= 2)
                                                {
                                                    Console.WriteLine("La palabra " + P6 + " es una palabra molesta");
                                                }
                                                else if (M6 >= 2)
                                                {
                                                    Console.WriteLine("La palabra " + P6 + " es una palabra molesta");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("La palabra " + P6 + " no es una palabra molesta");
                                                }


                                                A7 = P7.ToUpper();
                                                if (A7 == P7)
                                                {
                                                    Console.WriteLine("La palabra " + P7 + " es una palabra molesta");
                                                }
                                                else
                                                    for (j7 = 0; j7 < P7.Length; j7++)
                                                    {
                                                        i7 = P7[j7];
                                                        int c7 = char.ToLower(i7);
                                                        if ((c7 == '!') | (c7 == '¡'))
                                                        {
                                                            E7++;
                                                        }
                                                        else
                                                            for (l7 = 0; l7 < P7.Length; l7++)
                                                            {
                                                                m7 = P7[l7];
                                                                int k7 = char.ToLower(m7);
                                                                if ((k7 == '?') | (k7 == '¿')) ;
                                                                {
                                                                    M7++;
                                                                }
                                                            }
                                                        if (E7 >= 2)
                                                        {
                                                            Console.WriteLine("La palabra " + P7 + " es una palabra molesta");
                                                        }
                                                        else if (M7 >= 2)
                                                        {
                                                            Console.WriteLine("La palabra " + P7 + " es una palabra molesta");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("La palabra " + P7 + " no es una palabra molesta");
                                                        }


                                                        A8 = P8.ToUpper();
                                                        if (A8 == P8)
                                                        {
                                                            Console.WriteLine("La palabra " + P8 + " es una palabra molesta");
                                                        }
                                                        else
                                                            for (j8 = 0; j8 < P8.Length; j8++)
                                                            {
                                                                i8 = P8[j8];
                                                                int c8 = char.ToLower(i8);
                                                                if ((c8 == '!') | (c8 == '¡'))
                                                                {
                                                                    E8++;
                                                                }
                                                                else
                                                                    for (l8 = 0; l8 < P8.Length; l8++)
                                                                    {
                                                                        m8 = P8[l8];
                                                                        int k8 = char.ToLower(m8);
                                                                        if ((k8 == '?') | (k8 == '¿')) ;
                                                                        {
                                                                            M8++;
                                                                        }
                                                                    }
                                                                if (E8 >= 2)
                                                                {
                                                                    Console.WriteLine("La palabra " + P8 + " es una palabra molesta");
                                                                }
                                                                else if (M8 >= 2)
                                                                {
                                                                    Console.WriteLine("La palabra " + P8 + " es una palabra molesta");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("La palabra " + P8 + " no es una palabra molesta");
                                                                }


                                                                A9 = P9.ToUpper();
                                                                if (A9 == P9)
                                                                {
                                                                    Console.WriteLine("La palabra " + P9 + " es una palabra molesta");
                                                                }
                                                                else
                                                                    for (j9 = 0; j9 < P9.Length; j9++)
                                                                    {
                                                                        i9 = P9[j9];
                                                                        int c9 = char.ToLower(i9);
                                                                        if ((c9 == '!') | (c9 == '¡'))
                                                                        {
                                                                            E9++;
                                                                        }
                                                                        else
                                                                            for (l9 = 0; l9 < P9.Length; l9++)
                                                                            {
                                                                                m9 = P9[l9];
                                                                                int k9 = char.ToLower(m9);
                                                                                if ((k9 == '?') | (k9 == '¿')) ;
                                                                                {
                                                                                    M9++;
                                                                                }
                                                                            }
                                                                        if (E9 >= 2)
                                                                        {
                                                                            Console.WriteLine("La palabra " + P9 + " es una palabra molesta");
                                                                        }
                                                                        else if (M9 >= 2)
                                                                        {
                                                                            Console.WriteLine("La palabra " + P9 + " es una palabra molesta");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("La palabra " + P9 + " no es una palabra molesta");
                                                                        }


                                                                        A10 = P10.ToUpper();
                                                                        if (A10 == P10)
                                                                        {
                                                                            Console.WriteLine("La palabra " + P10 + " es una palabra molesta");
                                                                        }
                                                                        else
                                                                            for (j10 = 0; j10 < P10.Length; j10++)
                                                                            {
                                                                                i10 = P10[j10];
                                                                                int c10 = char.ToLower(i10);
                                                                                if ((c10 == '!') | (c10 == '¡'))
                                                                                {
                                                                                    E10++;
                                                                                }
                                                                                else
                                                                                    for (l10 = 0; l10 < P10.Length; l10++)
                                                                                    {
                                                                                        m10 = P10[l10];
                                                                                        int k10 = char.ToLower(m10);
                                                                                        if ((k10 == '?') | (k10 == '¿')) ;
                                                                                        {
                                                                                            M10++;
                                                                                        }
                                                                                    }
                                                                                if (E10 >= 2)
                                                                                {
                                                                                    Console.WriteLine("La palabra " + P10 + " es una palabra molesta");
                                                                                }
                                                                                else if (M10 >= 2)
                                                                                {
                                                                                    Console.WriteLine("La palabra " + P10 + " es una palabra molesta");
                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine("La palabra " + P10 + " no es una palabra molesta");
                                                                                }
                                                                                Console.ReadKey();
                                                                            }
                                                                    }
                                                            }
                                                    }
                                            }
                                    }
                            }
                    }
            }
    }
