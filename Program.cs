using System;
using System.Threading;

namespace project_frog_caglar
{
    class Program
    {
        static void Main(string[] args)
        {
            int posx = 55, posy = 14;
            ConsoleKeyInfo keyInfo;
            Console.CursorVisible = false;

            int carPosition = 0;
            int carLength = 0;
            int carType = 0;
            int carLane = 0;
            int level = 1;
            int life = 1;
            int whilegamescore = 0;
            int totalscore = 0;

            Random rnd = new Random();
            DateTime date1 = DateTime.Now;
            DateTime date2;
            int timer = 0;

            char[] lane1 = new char[60];
            char[] lane2 = new char[60];   //70 li olursa daha iyi ?
            char[] lane3 = new char[60];
            char[] lane4 = new char[60];

            for (int i = 0; i < 60; i++)
            {
                lane1[i] = '-';   //i sıralı indexine - koy
                lane2[i] = '-';
                lane3[i] = '-';
                lane4[i] = '-';
            }

            int lvl = 1;
            for (int i = 0; i < 12 - (2 * lvl); i++)
            {
                #region lane1-2 1hızlı araç kontrollü spawn
                carLane = rnd.Next(1, 3);
                carType = 1;

                if (carLane == 1)
                {
                    carPosition = rnd.Next(1, 46);
                    carLength = rnd.Next(2, 5);
                    if (carLength == 2 && lane1[carPosition - 1] == '-' && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && carPosition <= 47)  //position kontrolü ekle
                    {
                        lane1[carPosition] = Convert.ToChar(carType.ToString());
                        lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 3 && lane1[carPosition - 1] == '-' && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition + 3] == '-' && carPosition <= 46)
                    {
                        lane1[carPosition] = Convert.ToChar(carType.ToString());
                        lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                        lane1[carPosition + 2] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 4 && lane1[carPosition - 1] == '-' && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition + 3] == '-' && lane1[carPosition + 4] == '-' && carPosition <= 45)
                    {
                        lane1[carPosition] = Convert.ToChar(carType.ToString());
                        lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                        lane1[carPosition + 2] = Convert.ToChar(carType.ToString());
                        lane1[carPosition + 3] = Convert.ToChar(carType.ToString());
                    }
                    else
                        i--;
                }
                if (carLane == 2)
                {
                    carPosition = rnd.Next(1, 46);
                    carLength = rnd.Next(2, 5);
                    if (carLength == 2 && lane2[carPosition - 1] == '-' && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && carPosition <= 47)  //position kontrolü ekle
                    {
                        lane2[carPosition] = Convert.ToChar(carType.ToString());
                        lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 3 && lane2[carPosition - 1] == '-' && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition + 3] == '-' && carPosition <= 46)
                    {
                        lane2[carPosition] = Convert.ToChar(carType.ToString());
                        lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                        lane2[carPosition + 2] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 4 && lane2[carPosition - 1] == '-' && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition + 3] == '-' && lane2[carPosition + 4] == '-' && carPosition <= 45)
                    {
                        lane2[carPosition] = Convert.ToChar(carType.ToString());
                        lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                        lane2[carPosition + 2] = Convert.ToChar(carType.ToString());
                        lane2[carPosition + 3] = Convert.ToChar(carType.ToString());
                    }
                    else
                        i--;
                }
                #endregion
            }
            for (int i = 0; i < 2 * lvl; i++)
            {
                #region lane1-2 2hızlı araç kontrollü spawn
                carLane = rnd.Next(1, 3);
                carType = 2;

                if (carLane == 1)
                {
                    carPosition = rnd.Next(1, 46);
                    carLength = rnd.Next(2, 5);
                    if (carLength == 2 && lane1[carPosition - 1] == '-' && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && carPosition <= 47)  //position kontrolü ekle
                    {
                        lane1[carPosition] = Convert.ToChar(carType.ToString());
                        lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 3 && lane1[carPosition - 1] == '-' && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition + 3] == '-' && carPosition <= 46)
                    {
                        lane1[carPosition] = Convert.ToChar(carType.ToString());
                        lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                        lane1[carPosition + 2] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 4 && lane1[carPosition - 1] == '-' && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition + 3] == '-' && lane1[carPosition + 4] == '-' && carPosition <= 45)
                    {
                        lane1[carPosition] = Convert.ToChar(carType.ToString());
                        lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                        lane1[carPosition + 2] = Convert.ToChar(carType.ToString());
                        lane1[carPosition + 3] = Convert.ToChar(carType.ToString());
                    }
                    else
                        i--;
                }
                if (carLane == 2)
                {
                    carPosition = rnd.Next(1, 46);
                    carLength = rnd.Next(2, 5);
                    if (carLength == 2 && lane2[carPosition - 1] == '-' && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && carPosition <= 47)  //position kontrolü ekle
                    {
                        lane2[carPosition] = Convert.ToChar(carType.ToString());
                        lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 3 && lane2[carPosition - 1] == '-' && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition + 3] == '-' && carPosition <= 46)
                    {
                        lane2[carPosition] = Convert.ToChar(carType.ToString());
                        lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                        lane2[carPosition + 2] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 4 && lane2[carPosition - 1] == '-' && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition + 3] == '-' && lane2[carPosition + 4] == '-' && carPosition <= 45)
                    {
                        lane2[carPosition] = Convert.ToChar(carType.ToString());
                        lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                        lane2[carPosition + 2] = Convert.ToChar(carType.ToString());
                        lane2[carPosition + 3] = Convert.ToChar(carType.ToString());
                    }
                    else
                        i--;
                }
                #endregion
            }
            for (int i = 0; i < 12 - 2 * lvl; i++)
            {
                #region lane3-4 1hızlı araç kontrollü spawn
                carLane = rnd.Next(3, 5);
                carType = 1;

                if (carLane == 3)
                {
                    carPosition = rnd.Next(1, 46);
                    carLength = rnd.Next(2, 5);
                    if (carLength == 2 && lane3[carPosition] == '-' && lane3[carPosition + 1] == '-' && lane3[carPosition + 2] == '-' && lane3[carPosition - 1] == '-' && carPosition <= 47)  //position kontrolü ekle
                    {
                        lane3[carPosition] = Convert.ToChar(carType.ToString());
                        lane3[carPosition + 1] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 3 && lane3[carPosition] == '-' && lane3[carPosition + 1] == '-' && lane3[carPosition + 2] == '-' && lane3[carPosition + 3] == '-' && lane3[carPosition - 1] == '-' && carPosition <= 46)
                    {
                        lane3[carPosition] = Convert.ToChar(carType.ToString());
                        lane3[carPosition + 1] = Convert.ToChar(carType.ToString());
                        lane3[carPosition + 2] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 4 && lane3[carPosition] == '-' && lane3[carPosition + 1] == '-' && lane3[carPosition + 2] == '-' && lane3[carPosition + 3] == '-' && lane3[carPosition + 4] == '-' && lane3[carPosition - 1] == '-' && carPosition <= 45)
                    {
                        lane3[carPosition] = Convert.ToChar(carType.ToString());
                        lane3[carPosition + 1] = Convert.ToChar(carType.ToString());
                        lane3[carPosition + 2] = Convert.ToChar(carType.ToString());
                        lane3[carPosition + 3] = Convert.ToChar(carType.ToString());
                    }
                    else
                        i--;
                }
                if (carLane == 4)
                {
                    carPosition = rnd.Next(1, 46);
                    carLength = rnd.Next(2, 5);
                    if (carLength == 2 && lane4[carPosition] == '-' && lane4[carPosition + 1] == '-' && lane4[carPosition + 2] == '-' && lane4[carPosition - 1] == '-' && carPosition <= 47)  //position kontrolü ekle
                    {
                        lane4[carPosition] = Convert.ToChar(carType.ToString());
                        lane4[carPosition + 1] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 3 && lane4[carPosition] == '-' && lane4[carPosition + 1] == '-' && lane4[carPosition + 2] == '-' && lane4[carPosition + 3] == '-' && lane4[carPosition - 1] == '-' && carPosition <= 46)
                    {
                        lane4[carPosition] = Convert.ToChar(carType.ToString());
                        lane4[carPosition + 1] = Convert.ToChar(carType.ToString());
                        lane4[carPosition + 2] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 4 && lane4[carPosition] == '-' && lane4[carPosition + 1] == '-' && lane4[carPosition + 2] == '-' && lane4[carPosition + 3] == '-' && lane4[carPosition + 4] == '-' && lane4[carPosition - 1] == '-' && carPosition <= 45)
                    {
                        lane4[carPosition] = Convert.ToChar(carType.ToString());
                        lane4[carPosition + 1] = Convert.ToChar(carType.ToString());
                        lane4[carPosition + 2] = Convert.ToChar(carType.ToString());
                        lane4[carPosition + 3] = Convert.ToChar(carType.ToString());
                    }
                    else
                        i--;
                }
                #endregion
            }
            for (int i = 0; i < 2 * lvl; i++)
            {
                #region lane34 2 hızlı araç kontrollü spawn
                carLane = rnd.Next(3, 5);
                carType = 2;

                if (carLane == 3)
                {
                    carPosition = rnd.Next(4, 49);
                    carLength = rnd.Next(2, 5);
                    if (carLength == 2 && lane3[carPosition] == '-' && lane3[carPosition - 1] == '-' && lane3[carPosition - 2] == '-' && lane3[carPosition + 1] == '-' && carPosition <= 3)  //position kontrolü ekle
                    {
                        lane3[carPosition] = Convert.ToChar(carType.ToString());
                        lane3[carPosition - 1] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 3 && lane3[carPosition] == '-' && lane3[carPosition - 1] == '-' && lane3[carPosition - 2] == '-' && lane3[carPosition - 3] == '-' && lane3[carPosition + 1] == '-' && carPosition <= 4)
                    {
                        lane3[carPosition] = Convert.ToChar(carType.ToString());
                        lane3[carPosition - 1] = Convert.ToChar(carType.ToString());
                        lane3[carPosition - 2] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 4 && lane3[carPosition] == '-' && lane3[carPosition - 1] == '-' && lane3[carPosition - 2] == '-' && lane3[carPosition - 3] == '-' && lane3[carPosition - 4] == '-' && lane3[carPosition + 1] == '-' && carPosition <= 5)
                    {
                        lane3[carPosition] = Convert.ToChar(carType.ToString());
                        lane3[carPosition - 1] = Convert.ToChar(carType.ToString());
                        lane3[carPosition - 2] = Convert.ToChar(carType.ToString());
                        lane3[carPosition - 3] = Convert.ToChar(carType.ToString());
                    }
                    else
                        i--;
                }
                if (carLane == 4)
                {
                    carPosition = rnd.Next(4, 49);
                    carLength = rnd.Next(2, 5);
                    if (carLength == 2 && lane4[carPosition] == '-' && lane4[carPosition - 1] == '-' && lane4[carPosition - 2] == '-' && lane4[carPosition + 1] == '-' && carPosition <= 3)  //position kontrolü ekle
                    {
                        lane4[carPosition] = Convert.ToChar(carType.ToString());
                        lane4[carPosition - 1] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 3 && lane4[carPosition] == '-' && lane4[carPosition - 1] == '-' && lane4[carPosition - 2] == '-' && lane4[carPosition - 3] == '-' && lane4[carPosition + 1] == '-' && carPosition <= 4)
                    {
                        lane4[carPosition] = Convert.ToChar(carType.ToString());
                        lane4[carPosition - 1] = Convert.ToChar(carType.ToString());
                        lane4[carPosition - 2] = Convert.ToChar(carType.ToString());
                    }
                    else if (carLength == 4 && lane4[carPosition] == '-' && lane4[carPosition - 1] == '-' && lane4[carPosition - 2] == '-' && lane4[carPosition - 3] == '-' && lane4[carPosition - 4] == '-' && lane4[carPosition + 1] == '-' && carPosition <= 5)
                    {
                        lane4[carPosition] = Convert.ToChar(carType.ToString());
                        lane4[carPosition - 1] = Convert.ToChar(carType.ToString());
                        lane4[carPosition - 2] = Convert.ToChar(carType.ToString());
                        lane4[carPosition - 3] = Convert.ToChar(carType.ToString());
                    }
                    else
                        i--;
                }
                #endregion
            }
            #region yol kenarları ve yollar

            Console.SetCursorPosition(25, 10);
            for (int i = 0; i < 60; i++)
            {
                Console.Write(lane1[i]);       //i sıralı indextekini yazdır
            }
            Console.SetCursorPosition(25, 11);
            for (int j = 0; j < 60; j++)
            {
                Console.Write(lane2[j]);
            }
            Console.SetCursorPosition(25, 12);
            for (int k = 0; k < 60; k++)
            {
                Console.Write(lane3[k]);
            }
            Console.SetCursorPosition(25, 13);
            for (int l = 0; l < 60; l++)
            {
                Console.Write(lane4[l]);
            }

            #endregion

            while (true)//frog movement
            {
                Console.SetCursorPosition(30, 9);
                for (int o = 0; o < 50; o++)
                {
                    Console.Write("=");
                }
                Console.SetCursorPosition(30, 14);
                for (int p = 0; p < 50; p++)
                {
                    Console.Write("=");
                }

                #region player movement
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.RightArrow && posx < 79)  //Boundaries 
                    {
                        Console.SetCursorPosition(posx, posy);
                        if (posy == 9 || posy == 14)              //şeklin bozulmaması için
                            Console.Write("=");
                        else
                            Console.Write("-");
                        posx++;
                    }
                    else if (keyInfo.Key == ConsoleKey.LeftArrow && posx > 30)
                    {
                        Console.SetCursorPosition(posx, posy);
                        if (posy == 9 || posy == 14)
                            Console.Write("=");
                        else
                            Console.Write("-");
                        posx--;
                    }
                    else if (keyInfo.Key == ConsoleKey.UpArrow && posy > 9)
                    {
                        Console.SetCursorPosition(posx, posy);
                        if (posy == 9 || posy == 14)
                            Console.Write("=");
                        else
                            Console.Write("-");
                        posy--;
                    }
                    else if (keyInfo.Key == ConsoleKey.DownArrow && posy < 14)
                    {
                        Console.SetCursorPosition(posx, posy);
                        if (posy == 9 || posy == 14)
                            Console.Write("=");
                        else
                            Console.Write("-");
                        posy++;
                    }

                }
                #endregion
                date2 = DateTime.Now;
                TimeSpan ts = date2 - date1;
                if (ts.TotalMilliseconds / 1000 >= 1)
                {
                    timer++;
                    date1 = date2;
                    Console.SetCursorPosition(30, 8);
                    Console.WriteLine("Time :" + timer);

                    //shift
                    #region lane1 araç yavaşlama sollama kontrol
                    for (int i = 3; i < 60; i++)
                    {
                        if (lane1[i - 3] == '1' && lane1[i - 2] == '-' && lane1[i - 1] == '-' && lane1[i] == '2')// 2'nin önünde 1 varsa
                        {
                            if ((lane2[i - 2] == '-' && lane2[i - 1] == '-' && lane2[i] == '-' && lane2[i + 1] == '-') && lane1[i + 1] == '2' && lane1[i + 2] == '-')
                            {// aşağıdaki yolda yer varsa-- length 2 car
                                lane1[i] = '-'; lane1[i + 1] = '-';
                                lane2[i - 1] = '2'; lane2[i] = '2'; /*lane2[i + 1] = '2';*/

                            }
                            else if ((lane2[i - 2] == '-' && lane2[i - 1] == '-' && lane2[i] == '-' && lane2[i + 1] == '-' && lane2[i + 2] == '-') && lane1[i + 1] == '2' && lane1[i + 2] == '2' && lane1[i + 3] == '-')
                            {
                                lane1[i] = '-'; lane1[i + 1] = '-'; lane1[i + 2] = '-';
                                lane2[i - 1] = '2'; lane2[i] = '2'; lane2[i + 1] = '2';
                            }


                            else if ((lane2[i - 2] == '-' && lane2[i - 1] == '-' && lane2[i] == '-' && lane2[i + 1] == '-' && lane2[i + 2] == '-') && lane2[i + 3] == '-' && lane1[i + 2] == '2' && lane1[i + 2] == '2' && lane1[i + 3] == '2' && lane1[i + 4] == '-')
                            {// aşağıdaki yolda yer varsa-- length 4 car
                                lane1[i] = '-'; lane1[i + 1] = '-'; lane1[i + 2] = '-'; lane1[i + 3] = '-';
                                lane2[i - 1] = '2'; lane2[i] = '2'; lane2[i + 1] = '2'; lane2[i + 2] = '2'; /*lane2[i + 3] = '2';*/
                            }

                            else// aşağıdaki yolda yer yoksa
                            {
                                if (lane1[i + 1] == '2' && lane1[i + 2] == '-')// length 2, type2 car
                                {
                                    Console.WriteLine("length 2");
                                    lane1[i] = lane1[i + 1];
                                    lane1[i - 1] = lane1[i];
                                }
                                else if (lane1[i + 1] == '2' && lane1[i + 2] == '2' && lane1[i + 3] == '-')// length 3, type2 car
                                {
                                    Console.WriteLine("length 3");
                                    lane1[i + 1] = lane1[i + 2];
                                    lane1[i] = lane1[i + 1];
                                    lane1[i - 1] = lane1[i];
                                }
                                else if (lane1[i + 1] == '2' && lane1[i + 2] == '2' && lane1[i + 3] == '2' && lane1[i + 4] == '-')// length 4, type2 car
                                {
                                    Console.WriteLine("length 4");
                                    lane1[i + 2] = lane1[i + 3];
                                    lane1[i + 1] = lane1[i + 2];
                                    lane1[i] = lane1[i + 1];
                                    lane1[i - 1] = lane1[i];
                                }
                            }
                        }
                        if (lane1[i - 3] == '-' && lane1[i - 2] == '-' && lane1[i - 1] == '-' && lane1[i] == '2')//'2 nin önünde araba yoksa
                        {
                            if (lane1[i + 1] == '2' && lane1[i + 2] == '-')// length 2, type2 car
                            {
                                Console.WriteLine("length 2sub");
                                lane1[i - 2] = lane1[i];
                                lane1[i + 1] = '-';
                                lane1[i - 1] = '2';
                            }
                            else if (lane1[i + 1] == '2' && lane1[i + 2] == '2' && lane1[i + 3] == '-')// length 3, type2 car
                            {
                                Console.WriteLine("length 3sub");
                                lane1[i - 2] = lane1[i];
                                lane1[i + 2] = '-';
                                lane1[i - 1] = '2';
                                lane1[i] = '2';
                            }
                            else if (lane1[i + 1] == '2' && lane1[i + 2] == '2' && lane1[i + 3] == '2' && lane1[i + 4] == '-')// length 4, type2 car
                            {
                                Console.WriteLine("length 4sub");
                                lane1[i - 2] = lane1[i];
                                lane1[i + 3] = '-';
                                lane1[i - 1] = '2';
                                lane1[i] = '2';
                                lane1[i + 1] = '2';
                            }

                        }


                        else// 2'yi ilgilendiren durumlar dışında
                        {
                            lane1[i - 1] = lane1[i];

                        }
                        if (lane1[5] == '1' || lane1[5] == '2')
                        {

                            #region lane1 araç spawn
                            if (lane2[55] == '-' && lane1[56] == '-' && lane1[57] == '-' && lane1[58] == '-' && lane1[59] == '-')
                            {
                                carType = rnd.Next(1, 3);
                                carPosition = 55;
                                carLength = rnd.Next(2, 5);
                                if (carLength == 2 && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition - 1] == '-')  //position kontrolü ekle
                                {
                                    lane1[carPosition] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 3 && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition + 3] == '-' && lane1[carPosition - 1] == '-')
                                {
                                    lane1[carPosition] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 2] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 4 && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition + 3] == '-' && lane1[carPosition + 4] == '-' && lane1[carPosition - 1] == '-')
                                {
                                    lane1[carPosition] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 2] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 3] = Convert.ToChar(carType.ToString());
                                }
                            }
                            #endregion
                        }
                    }
                    #endregion
                    #region lane2 araç yavaşlama sollama kontrol
                    for (int i = 3; i < 60; i++)
                    {

                        if (lane2[i - 3] == '1' && lane2[i - 2] == '-' && lane2[i - 1] == '-' && lane2[i] == '2')// 2'nin önünde 1 varsa
                        {
                            if ((lane1[i - 2] == '-' && lane1[i - 1] == '-' && lane1[i] == '-' && lane1[i + 1] == '-') && lane2[i + 1] == '2' && lane2[i + 2] == '-')
                            {// aşağıdaki yolda yer varsa-- length 2 car
                                lane2[i] = '-'; lane2[i + 1] = '-';
                                lane1[i - 1] = '2'; lane1[i] = '2';
                            }
                            else if ((lane1[i - 2] == '-' && lane1[i - 1] == '-' && lane1[i] == '-' && lane1[i + 1] == '-' && lane1[i + 2] == '-') && lane2[i + 1] == '2' && lane2[i + 2] == '2' && lane2[i + 3] == '-')
                            {// aşağıdaki yolda yer varsa-- length  car
                                lane2[i] = '-'; lane2[i + 1] = '-'; lane2[i + 2] = '-';
                                lane1[i - 1] = '2'; lane1[i] = '2'; lane1[i + 1] = '2';
                            }
                            else if ((lane1[i - 2] == '-' && lane1[i - 1] == '-' && lane1[i] == '-' && lane1[i + 1] == '-' && lane1[i + 2] == '-') && lane1[i + 3] == '-' && lane2[i + 2] == '2' && lane2[i + 2] == '2' && lane2[i + 3] == '2' && lane2[i + 4] == '-')
                            {// aşağıdaki yolda yer varsa-- length 4 car
                                lane2[i] = '-'; lane2[i + 1] = '-'; lane2[i + 2] = '-'; lane2[i + 3] = '-';
                                lane1[i - 1] = '2'; lane1[i] = '2'; lane1[i + 1] = '2'; lane1[i + 2] = '2'; /*lane2[i + 3] = '2';*/
                            }
                            else// aşağıdaki yolda yer yoksa
                            {
                                if (lane2[i + 1] == '2' && lane2[i + 2] == '-')// length 2, type2 car
                                {
                                    Console.WriteLine("length 2");
                                    lane2[i] = lane2[i + 1];
                                    lane2[i - 1] = lane2[i];
                                }
                                else if (lane2[i + 1] == '2' && lane2[i + 2] == '2' && lane2[i + 3] == '-')// length 3, type2 car
                                {
                                    Console.WriteLine("length 3");
                                    lane2[i + 1] = lane2[i + 2];
                                    lane2[i] = lane2[i + 1];
                                    lane2[i - 1] = lane2[i];
                                }
                                else if (lane2[i + 1] == '2' && lane2[i + 2] == '2' && lane2[i + 3] == '2' && lane2[i + 4] == '-')// length 4, type2 car
                                {
                                    Console.WriteLine("length 4");
                                    lane2[i + 2] = lane2[i + 3];
                                    lane2[i + 1] = lane2[i + 2];
                                    lane2[i] = lane2[i + 1];
                                    lane2[i - 1] = lane2[i];
                                }
                            }
                        }
                        if (lane2[i - 3] == '-' && lane2[i - 2] == '-' && lane2[i - 1] == '-' && lane2[i] == '2')//'2 nin önünde araba yoksa
                        {
                            if (lane2[i + 1] == '2' && lane2[i + 2] == '-')// length 2, type2 car
                            {
                                Console.WriteLine("length 2sub");
                                lane2[i - 2] = lane2[i];
                                lane2[i + 1] = '-';
                                lane2[i - 1] = '2';
                            }
                            else if (lane2[i + 1] == '2' && lane2[i + 2] == '2' && lane2[i + 3] == '-')// length 3, type2 car
                            {
                                Console.WriteLine("length 3sub");
                                lane2[i - 2] = lane2[i];
                                lane2[i + 2] = '-';
                                lane2[i - 1] = '2';
                                lane2[i] = '2';
                            }
                            else if (lane2[i + 1] == '2' && lane2[i + 2] == '2' && lane2[i + 3] == '2' && lane2[i + 4] == '-')// length 4, type2 car
                            {
                                Console.WriteLine("length 4sub");
                                lane2[i - 2] = lane2[i];
                                lane2[i + 3] = '-';
                                lane2[i - 1] = '2';
                                lane2[i] = '2';
                                lane2[i + 1] = '2';
                            }
                        }
                        else// 2'yi ilgilendiren durumlar dışında
                        {
                            lane2[i - 1] = lane2[i];

                        }


                        if (lane2[5] == '1' || lane2[5] == '2')
                        {

                            #region lane2 araç spawn
                            if (lane2[55] == '-' && lane2[56] == '-' && lane2[57] == '-' && lane2[58] == '-' && lane2[59] == '-')
                            {
                                carType = rnd.Next(1, 3);
                                carPosition = 55;
                                carLength = rnd.Next(2, 5);
                                if (carLength == 2 && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition - 1] == '-')  //position kontrolü ekle
                                {
                                    lane2[carPosition] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 3 && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition + 3] == '-' && lane2[carPosition - 1] == '-')
                                {
                                    lane2[carPosition] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 2] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 4 && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition + 3] == '-' && lane2[carPosition + 4] == '-' && lane2[carPosition - 1] == '-')
                                {
                                    lane2[carPosition] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 2] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 3] = Convert.ToChar(carType.ToString());
                                }
                            }
                            #endregion
                        }
                    }
                    #endregion
                    #region lane3 araç yavaşlama sollama kontrol
                    for (int i = 56; i > 4; i--)
                    {
                        if (lane3[i + 3] == '1' && lane3[i + 2] == '-' && lane3[i + 1] == '-' && lane3[i] == '2')// 2'nin önünde 1 varsa
                        {//Kontrol edildi, 3ü de
                            if ((lane4[i + 2] == '-' && lane4[i + 1] == '-' && lane4[i] == '-' && lane4[i - 1] == '-') && lane3[i - 1] == '2' && lane3[i - 2] == '-')
                            {// aşağıdaki yolda yer varsa-- length 2 car
                                lane3[i] = '-'; lane3[i - 1] = '-';
                                lane4[i + 1] = '2'; lane4[i] = '2';

                            }
                            else if ((lane4[i + 2] == '-' && lane4[i + 1] == '-' && lane4[i] == '-' && lane4[i - 1] == '-' && lane4[i - 2] == '-') && lane3[i - 1] == '2' && lane3[i - 2] == '2' && lane3[i - 3] == '-')
                            {
                                lane3[i] = '-'; lane3[i - 1] = '-'; lane3[i - 2] = '-';
                                lane4[i + 1] = '2'; lane4[i] = '2'; lane4[i - 1] = '2';

                            }
                            else if ((lane4[i + 2] == '-' && lane4[i + 1] == '-' && lane4[i] == '-' && lane4[i - 1] == '-' && lane4[i - 2] == '-') && lane4[i - 3] == '-' && lane3[i - 2] == '2' && lane3[i - 3] == '2' && lane3[i - 4] == '-')
                            {// aşağıdaki yolda yer varsa-- length 4 car
                                lane3[i] = '-'; lane3[i - 1] = '-'; lane3[i - 2] = '-'; lane3[i - 3] = '-';
                                lane4[i + 1] = '2'; lane4[i] = '2'; lane4[i - 1] = '2'; lane4[i - 2] = '2';

                            }
                            else// aşağıdaki yolda yer yoksa
                            {// kontrol edildi, 3ü de
                                if (lane3[i - 1] == '2' && lane3[i - 2] == '-')// length 2, type2 car
                                {
                                    Console.WriteLine("length 2");
                                    lane3[i] = lane3[i - 1];
                                    lane3[i + 1] = lane3[i];


                                }
                                else if (lane3[i - 1] == '2' && lane3[i - 2] == '2' && lane3[i - 3] == '-')// length 3, type2 car
                                {
                                    Console.WriteLine("length 3");
                                    lane3[i - 1] = lane3[i - 2];
                                    lane3[i] = lane3[i - 1];
                                    lane3[i + 1] = lane3[i];
                                }
                                else if (lane3[i - 1] == '2' && lane3[i - 2] == '2' && lane3[i - 3] == '2' && lane3[i - 4] == '-')// length 4, type2 car
                                {
                                    Console.WriteLine("length 4");
                                    lane3[i - 2] = lane3[i - 3];
                                    lane3[i - 1] = lane3[i - 2];
                                    lane3[i] = lane3[i - 1];
                                    lane3[i + 1] = lane3[i];
                                }
                            }
                        }
                        if (lane3[i + 3] == '-' && lane3[i + 2] == '-' && lane3[i + 1] == '-' && lane3[i] == '2')//'2 nin önünde araba yoksa
                        {
                            if (lane3[i - 1] == '2' && lane3[i - 2] == '-')// length 2, type2 car
                            {//üçü de kontrol edildi
                                Console.WriteLine("length 2sub");
                                lane3[i + 2] = lane3[i];
                                lane3[i - 1] = '-';
                                lane3[i + 1] = '2';
                            }
                            else if (lane3[i - 1] == '2' && lane3[i - 2] == '2' && lane3[i - 3] == '-')// length 3, type2 car
                            {
                                Console.WriteLine("length 3sub");
                                lane3[i + 2] = lane3[i];
                                lane3[i - 2] = '-';
                                lane3[i + 1] = '2';
                                lane3[i] = '2';
                            }
                            else if (lane3[i - 1] == '2' && lane3[i - 2] == '2' && lane3[i - 3] == '2' && lane3[i - 4] == '-')// length 4, type2 car
                            {
                                Console.WriteLine("length 4sub");
                                lane3[i + 2] = lane3[i];
                                lane3[i - 3] = '-';
                                lane3[i + 1] = '2';
                                lane3[i] = '2';
                                lane3[i - 1] = '2';
                            }

                        }
                        else// 2'yi ilgilendiren durumlar dışında
                        {// Kontrol edildi
                            lane3[i + 1] = lane3[i];

                        }
                        if (lane3[55] == '1' || lane3[55] == '2')
                        {

                            #region lane3 araç spawn
                            if (lane3[0] == '-' && lane3[1] == '-' && lane3[2] == '-' && lane3[3] == '-' && lane3[4] == '-')
                            {
                                carPosition = 5;
                                carLength = rnd.Next(2, 5);
                                if (carLength == 2 && lane3[carPosition] == '-' && lane3[carPosition - 1] == '-' && lane3[carPosition - 2] == '-' && lane3[carPosition + 1] == '-' && carPosition <= 3)  //position kontrolü ekle
                                {
                                    lane3[carPosition] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition - 1] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 3 && lane3[carPosition] == '-' && lane3[carPosition - 1] == '-' && lane3[carPosition - 2] == '-' && lane3[carPosition - 3] == '-' && lane3[carPosition + 1] == '-' && carPosition <= 4)
                                {
                                    lane3[carPosition] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition - 1] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition - 2] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 4 && lane3[carPosition] == '-' && lane3[carPosition - 1] == '-' && lane3[carPosition - 2] == '-' && lane3[carPosition - 3] == '-' && lane3[carPosition - 4] == '-' && lane3[carPosition + 1] == '-' && carPosition <= 5)
                                {
                                    lane3[carPosition] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition - 1] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition - 2] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition - 3] = Convert.ToChar(carType.ToString());
                                }
                            }
                            #endregion
                        }
                        #endregion


                    }
                    #region lane4 araç yavaşlama sollama kontrol
                    for (int i = 56; i > 4; i--)
                    {
                        if (lane4[i + 3] == '1' && lane4[i + 2] == '-' && lane4[i + 1] == '-' && lane4[i] == '2')// 2'nin önünde 1 varsa
                        {// Kontrol edildi,3 de
                            if ((lane3[i + 2] == '-' && lane3[i + 1] == '-' && lane3[i] == '-' && lane3[i - 1] == '-') && lane4[i - 1] == '2' && lane4[i - 2] == '-')
                            {// yukarıdaki yolda yer varsa-- length 2 car
                                lane4[i] = '-'; lane4[i - 1] = '-';
                                lane3[i + 1] = '2'; lane3[i] = '2';
                            }
                            else if ((lane3[i + 2] == '-' && lane3[i + 1] == '-' && lane3[i] == '-' && lane3[i - 1] == '-' && lane3[i - 2] == '-') && lane4[i - 1] == '2' && lane4[i - 2] == '2' && lane4[i - 3] == '-')
                            {
                                lane4[i] = '-'; lane4[i - 1] = '-'; lane4[i - 2] = '-';
                                lane3[i + 1] = '2'; lane3[i] = '2'; lane3[i - 1] = '2';
                            }
                            else if ((lane3[i + 2] == '-' && lane3[i + 1] == '-' && lane3[i] == '-' && lane3[i - 1] == '-' && lane3[i - 2] == '-') && lane3[i - 3] == '-' && lane4[i - 1] == '2' && lane4[i - 2] == '2' && lane4[i - 3] == '2' && lane4[i - 4] == '-')
                            {// aşağıdaki yolda yer varsa-- length 4 car
                                lane4[i] = '-'; lane4[i - 1] = '-'; lane4[i - 2] = '-'; lane4[i - 3] = '-';
                                lane3[i + 1] = '2'; lane3[i] = '2'; lane3[i - 1] = '2'; lane3[i - 2] = '2'; /*lane2[i + 3] = '2';*/

                            }
                            else// yukarıdaki yolda yer yoksa
                            {
                                if (lane4[i - 1] == '2' && lane4[i - 2] == '-')// length 2, type2 car
                                {// Kontrol edildi
                                    Console.WriteLine("length 2");
                                    lane4[i] = lane4[i - 1];
                                    lane4[i + 1] = lane4[i];


                                }
                                else if (lane4[i - 1] == '2' && lane4[i - 2] == '2' && lane4[i - 3] == '-')// length 3, type2 car
                                {// Kontrol edildi
                                    Console.WriteLine("length 3");
                                    lane4[i - 1] = lane4[i - 2];
                                    lane4[i] = lane4[i - 1];
                                    lane4[i + 1] = lane4[i];

                                }
                                else if (lane4[i - 1] == '2' && lane4[i - 2] == '2' && lane4[i - 3] == '2' && lane4[i - 4] == '-')// length 4, type2 car
                                {// Kontrol edildi
                                    Console.WriteLine("length 4");
                                    lane4[i - 2] = lane4[i - 3];
                                    lane4[i - 1] = lane4[i - 2];
                                    lane4[i] = lane4[i - 1];
                                    lane4[i + 1] = lane4[i];
                                }
                            }
                        }
                        if (lane4[i + 3] == '-' && lane4[i + 2] == '-' && lane4[i + 1] == '-' && lane4[i] == '2')//'2 nin önünde araba yoksa
                        {
                            if (lane4[i - 1] == '2' && lane4[i - 2] == '-')// length 2, type2 car
                            {
                                Console.WriteLine("length 2sub");
                                lane4[i + 2] = lane4[i];
                                lane4[i - 1] = '-';
                                lane4[i + 1] = '2';
                            }
                            else if (lane4[i - 1] == '2' && lane4[i - 2] == '2' && lane4[i - 3] == '-')// length 3, type2 car
                            {
                                Console.WriteLine("length 3sub");
                                lane4[i + 2] = lane4[i];
                                lane4[i - 2] = '-';
                                lane4[i + 1] = '2';
                                lane4[i] = '2';
                            }
                            else if (lane4[i - 1] == '2' && lane4[i - 2] == '2' && lane4[i - 3] == '2' && lane4[i - 4] == '-')// length 4, type2 car
                            {
                                Console.WriteLine("length 4sub");
                                lane4[i + 2] = lane4[i];
                                lane4[i - 3] = '-';
                                lane4[i + 1] = '2';
                                lane4[i] = '2';
                                lane4[i - 1] = '2';
                            }

                        }// Kontrol edildi
                        else// 2'yi ilgilendiren durumlar dışında// Kontrol edildi
                        {
                            lane4[i + 1] = lane4[i];

                        }
                        if (lane4[55] == '1' || lane4[55] == '2')
                        {

                            #region lane4 araç spawn
                            if (lane4[0] == '-' && lane4[1] == '-' && lane4[2] == '-' && lane4[3] == '-' && lane4[4] == '-')
                            {
                                carPosition = 5;
                                carLength = rnd.Next(2, 5);
                                if (carLength == 2 && lane4[carPosition] == '-' && lane4[carPosition - 1] == '-' && lane4[carPosition - 2] == '-' && lane4[carPosition + 1] == '-' && carPosition <= 3)  //position kontrolü ekle
                                {
                                    lane4[carPosition] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition - 1] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 3 && lane4[carPosition] == '-' && lane4[carPosition - 1] == '-' && lane4[carPosition - 2] == '-' && lane4[carPosition - 3] == '-' && lane4[carPosition + 1] == '-' && carPosition <= 4)
                                {
                                    lane4[carPosition] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition - 1] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition - 2] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 4 && lane4[carPosition] == '-' && lane4[carPosition - 1] == '-' && lane4[carPosition - 2] == '-' && lane4[carPosition - 3] == '-' && lane4[carPosition - 4] == '-' && lane4[carPosition + 1] == '-' && carPosition <= 5)
                                {
                                    lane4[carPosition] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition - 1] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition - 2] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition - 3] = Convert.ToChar(carType.ToString());
                                }
                            }
                            #endregion
                        }
                    }
                    #endregion



                    Console.SetCursorPosition(80, 10);
                    Console.Write("     ");
                    Console.SetCursorPosition(80, 11);
                    Console.Write("     ");
                    Console.SetCursorPosition(80, 12);
                    Console.Write("     ");
                    Console.SetCursorPosition(80, 13);
                    Console.Write("     ");
                    Console.SetCursorPosition(25, 10);
                    Console.Write("     ");
                    Console.SetCursorPosition(25, 11);
                    Console.Write("     ");
                    Console.SetCursorPosition(25, 12);
                    Console.Write("     ");
                    Console.SetCursorPosition(25, 13);
                    Console.Write("     ");


                    //print
                    for (int i = 0; i < 60; i++)
                    {
                        Console.SetCursorPosition(25, 10);
                        Console.Write(lane1);       //i sıralı indextekini yazdır
                        Console.SetCursorPosition(25, 11);
                        Console.Write(lane2);       //i sıralı indextekini yazdır
                        Console.SetCursorPosition(25, 12);
                        Console.Write(lane3);       //i sıralı indextekini yazdır
                        Console.SetCursorPosition(25, 13);
                        Console.Write(lane4);       //i sıralı indextekini yazdır
                    }
                    Console.SetCursorPosition(80, 10);
                    Console.Write("     ");
                    Console.SetCursorPosition(80, 11);
                    Console.Write("     ");
                    Console.SetCursorPosition(80, 12);
                    Console.Write("     ");
                    Console.SetCursorPosition(80, 13);
                    Console.Write("     ");
                    Console.SetCursorPosition(25, 10);
                    Console.Write("     ");
                    Console.SetCursorPosition(25, 11);
                    Console.Write("     ");
                    Console.SetCursorPosition(25, 12);
                    Console.Write("     ");
                    Console.SetCursorPosition(25, 13);
                    Console.Write("     ");

                    Console.SetCursorPosition(71, 7);
                    Console.Write("LEVEL : " + level);
                    Console.SetCursorPosition(50, 7);
                    Console.Write("LIFE : " + life);
                    whilegamescore = 60 - timer;
                    Console.SetCursorPosition(50, 6);
                    Console.Write("SCORE : " + whilegamescore);
                    Console.SetCursorPosition(posx, posy);
                    Console.Write("F");

                    Thread.Sleep(1000);
                    if (life == 0)
                    {
                        Console.Clear();
                        Console.Write("GAME OVER");
                        Console.ReadLine();
                        break;
                    }
                    if (life > 0)
                    {
                        if (((lane1[posx] == '1' || lane1[posx] == '2') && posy == 10) || ((lane2[posx] == '1' || lane2[posx] == '2') && posy == 11) || ((lane3[posx] == '1' || lane3[posx] == '2') && posy == 12) || ((lane4[posx] == '1' || lane4[posx] == '2') && posy == 13))
                        {
                            life = life - 1;
                            Console.SetCursorPosition(55, 14);
                            posx = 55;
                            posy = 14;
                            Console.Write("F");
                        }
                    }
                    if (posy == 9)
                    {
                        lvl++;
                        level++;
                        life++;
                        Console.Clear();
                        Console.SetCursorPosition(55, 14);
                        posx = 55;
                        posy = 14;
                        Console.Write("F");
                        for (int i = 0; i < 60; i++)
                        {
                            lane1[i] = '-';   //i sıralı indexine - koy
                            lane2[i] = '-';
                            lane3[i] = '-';
                            lane4[i] = '-';
                        }
                        for (int i = 0; i < 12 - (2 * lvl); i++)
                        {
                            #region lane1-2 1hızlı araç kontrollü spawn
                            carLane = rnd.Next(1, 3);
                            carType = 1;

                            if (carLane == 1)
                            {
                                carPosition = rnd.Next(1, 46);
                                carLength = rnd.Next(2, 5);
                                if (carLength == 2 && lane1[carPosition - 1] == '-' && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && carPosition <= 47)  //position kontrolü ekle
                                {
                                    lane1[carPosition] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 3 && lane1[carPosition - 1] == '-' && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition + 3] == '-' && carPosition <= 46)
                                {
                                    lane1[carPosition] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 2] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 4 && lane1[carPosition - 1] == '-' && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition + 3] == '-' && lane1[carPosition + 4] == '-' && carPosition <= 45)
                                {
                                    lane1[carPosition] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 2] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 3] = Convert.ToChar(carType.ToString());
                                }

                            }
                            if (carLane == 2)
                            {
                                carPosition = rnd.Next(1, 46);
                                carLength = rnd.Next(2, 5);
                                if (carLength == 2 && lane2[carPosition - 1] == '-' && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && carPosition <= 47)  //position kontrolü ekle
                                {
                                    lane2[carPosition] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 3 && lane2[carPosition - 1] == '-' && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition + 3] == '-' && carPosition <= 46)
                                {
                                    lane2[carPosition] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 2] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 4 && lane2[carPosition - 1] == '-' && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition + 3] == '-' && lane2[carPosition + 4] == '-' && carPosition <= 45)
                                {
                                    lane2[carPosition] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 2] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 3] = Convert.ToChar(carType.ToString());
                                }

                            }
                            #endregion
                        }
                        for (int i = 0; i < 2 * lvl; i++)
                        {
                            #region lane1-2 2hızlı araç kontrollü spawn
                            carLane = rnd.Next(1, 3);
                            carType = 2;

                            if (carLane == 1)
                            {
                                carPosition = rnd.Next(1, 46);
                                carLength = rnd.Next(2, 5);
                                if (carLength == 2 && lane1[carPosition - 1] == '-' && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && carPosition <= 47)  //position kontrolü ekle
                                {
                                    lane1[carPosition] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 3 && lane1[carPosition - 1] == '-' && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition + 3] == '-' && carPosition <= 46)
                                {
                                    lane1[carPosition] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 2] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 4 && lane1[carPosition - 1] == '-' && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition + 3] == '-' && lane1[carPosition + 4] == '-' && carPosition <= 45)
                                {
                                    lane1[carPosition] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 2] = Convert.ToChar(carType.ToString());
                                    lane1[carPosition + 3] = Convert.ToChar(carType.ToString());
                                }

                            }
                            if (carLane == 2)
                            {
                                carPosition = rnd.Next(1, 46);
                                carLength = rnd.Next(2, 5);
                                if (carLength == 2 && lane2[carPosition - 1] == '-' && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && carPosition <= 47)  //position kontrolü ekle
                                {
                                    lane2[carPosition] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 3 && lane2[carPosition - 1] == '-' && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition + 3] == '-' && carPosition <= 46)
                                {
                                    lane2[carPosition] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 2] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 4 && lane2[carPosition - 1] == '-' && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition + 3] == '-' && lane2[carPosition + 4] == '-' && carPosition <= 45)
                                {
                                    lane2[carPosition] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 2] = Convert.ToChar(carType.ToString());
                                    lane2[carPosition + 3] = Convert.ToChar(carType.ToString());
                                }

                            }
                            #endregion
                        }
                        for (int i = 0; i < 12 - 2 * lvl; i++)
                        {
                            #region lane3-4 1hızlı araç kontrollü spawn
                            carLane = rnd.Next(3, 5);
                            carType = 1;

                            if (carLane == 3)
                            {
                                carPosition = rnd.Next(1, 46);
                                carLength = rnd.Next(2, 5);
                                if (carLength == 2 && lane3[carPosition] == '-' && lane3[carPosition + 1] == '-' && lane3[carPosition + 2] == '-' && lane3[carPosition - 1] == '-' && carPosition <= 47)  //position kontrolü ekle
                                {
                                    lane3[carPosition] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition + 1] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 3 && lane3[carPosition] == '-' && lane3[carPosition + 1] == '-' && lane3[carPosition + 2] == '-' && lane3[carPosition + 3] == '-' && lane3[carPosition - 1] == '-' && carPosition <= 46)
                                {
                                    lane3[carPosition] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition + 2] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 4 && lane3[carPosition] == '-' && lane3[carPosition + 1] == '-' && lane3[carPosition + 2] == '-' && lane3[carPosition + 3] == '-' && lane3[carPosition + 4] == '-' && lane3[carPosition - 1] == '-' && carPosition <= 45)
                                {
                                    lane3[carPosition] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition + 2] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition + 3] = Convert.ToChar(carType.ToString());
                                }
                                else
                                    i--;
                            }
                            if (carLane == 4)
                            {
                                carPosition = rnd.Next(1, 46);
                                carLength = rnd.Next(2, 5);
                                if (carLength == 2 && lane4[carPosition] == '-' && lane4[carPosition + 1] == '-' && lane4[carPosition + 2] == '-' && lane4[carPosition - 1] == '-' && carPosition <= 47)  //position kontrolü ekle
                                {
                                    lane4[carPosition] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition + 1] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 3 && lane4[carPosition] == '-' && lane4[carPosition + 1] == '-' && lane4[carPosition + 2] == '-' && lane4[carPosition + 3] == '-' && lane4[carPosition - 1] == '-' && carPosition <= 46)
                                {
                                    lane4[carPosition] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition + 2] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 4 && lane4[carPosition] == '-' && lane4[carPosition + 1] == '-' && lane4[carPosition + 2] == '-' && lane4[carPosition + 3] == '-' && lane4[carPosition + 4] == '-' && lane4[carPosition - 1] == '-' && carPosition <= 45)
                                {
                                    lane4[carPosition] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition + 1] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition + 2] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition + 3] = Convert.ToChar(carType.ToString());
                                }
                                else
                                    i--;
                            }
                            #endregion
                        }
                        for (int i = 0; i < 2 * lvl; i++)
                        {
                            #region lane34 2 hızlı araç kontrollü spawn
                            carLane = rnd.Next(3, 5);
                            carType = 2;

                            if (carLane == 3)
                            {
                                carPosition = rnd.Next(4, 49);
                                carLength = rnd.Next(2, 5);
                                if (carLength == 2 && lane3[carPosition] == '-' && lane3[carPosition - 1] == '-' && lane3[carPosition - 2] == '-' && lane3[carPosition + 1] == '-' && carPosition <= 3)  //position kontrolü ekle
                                {
                                    lane3[carPosition] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition - 1] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 3 && lane3[carPosition] == '-' && lane3[carPosition - 1] == '-' && lane3[carPosition - 2] == '-' && lane3[carPosition - 3] == '-' && lane3[carPosition + 1] == '-' && carPosition <= 4)
                                {
                                    lane3[carPosition] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition - 1] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition - 2] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 4 && lane3[carPosition] == '-' && lane3[carPosition - 1] == '-' && lane3[carPosition - 2] == '-' && lane3[carPosition - 3] == '-' && lane3[carPosition - 4] == '-' && lane3[carPosition + 1] == '-' && carPosition <= 5)
                                {
                                    lane3[carPosition] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition - 1] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition - 2] = Convert.ToChar(carType.ToString());
                                    lane3[carPosition - 3] = Convert.ToChar(carType.ToString());
                                }

                            }
                            if (carLane == 4)
                            {
                                carPosition = rnd.Next(4, 49);
                                carLength = rnd.Next(2, 5);
                                if (carLength == 2 && lane4[carPosition] == '-' && lane4[carPosition - 1] == '-' && lane4[carPosition - 2] == '-' && lane4[carPosition + 1] == '-' && carPosition <= 3)  //position kontrolü ekle
                                {
                                    lane4[carPosition] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition - 1] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 3 && lane4[carPosition] == '-' && lane4[carPosition - 1] == '-' && lane4[carPosition - 2] == '-' && lane4[carPosition - 3] == '-' && lane4[carPosition + 1] == '-' && carPosition <= 4)
                                {
                                    lane4[carPosition] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition - 1] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition - 2] = Convert.ToChar(carType.ToString());
                                }
                                else if (carLength == 4 && lane4[carPosition] == '-' && lane4[carPosition - 1] == '-' && lane4[carPosition - 2] == '-' && lane4[carPosition - 3] == '-' && lane4[carPosition - 4] == '-' && lane4[carPosition + 1] == '-' && carPosition <= 5)
                                {
                                    lane4[carPosition] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition - 1] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition - 2] = Convert.ToChar(carType.ToString());
                                    lane4[carPosition - 3] = Convert.ToChar(carType.ToString());
                                }

                            }
                            #endregion
                        }

                    }


                }
            }

        }
    }
}

