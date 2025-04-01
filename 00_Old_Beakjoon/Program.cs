using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    internal class Program
    {
        static int asd = 1000000000;
        static void Main(string[] args)
        {

            /* A-B
                        string a = Console.ReadLine();
                        string[] e = a.Split(' ');
                        int q = int.Parse(e[0]);
                        int z = int.Parse(e[1]);
                        Console.WriteLine(q - z);
            */

            /*//A*B
            string[] a = Console.ReadLine().Split(' ');
            int v = int.Parse(a[0]);
            int e = int.Parse(a[1]);
            Console.WriteLine(v - e);

*/

            /*//A/B
            float[] z = Array.ConvertAll(Console.ReadLine().Split(' '), float.Parse);
            Console.WriteLine(z[0] / z[1]);

*/

            /*// 사칙연산
            int[] e = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine(e[0] + e[1]);
            Console.WriteLine(e[0] - e[1]);
            Console.WriteLine(e[0] * e[1]);
            Console.WriteLine(e[0] / e[1]);
            Console.WriteLine(e[0] % e[1]);
*/

            /*//??!
            string name = Console.ReadLine();
            Console.WriteLine($"{name}??!");
*/

            /*//1998년생인 내가 태국에서는 2541년생?!
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(year-543);
*/

            /*//나머지
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int A = array[0], B = array[1], C = array[2];
            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A*B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
*/

            /*//곱셉
            int fNum = int.Parse(Console.ReadLine());
            int lNum = int.Parse(Console.ReadLine());

            int lOnesDigit = lNum % 10;
            int lTensDigit = (lNum % 100) - (lNum % 10);
            int lHundredsDigit = (lNum % 1000) - (lNum % 100);


            Console.WriteLine(fNum * lOnesDigit);
            Console.WriteLine(fNum * lTensDigit / 10);
            Console.WriteLine(fNum * lHundredsDigit / 100);
            Console.WriteLine((fNum * lOnesDigit) + (fNum * lTensDigit) + (fNum * lHundredsDigit));
*/

            /*//꼬마 정민
            long[] array = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            Console.WriteLine(array[0] + array[1] + array[2]);
*/

            /*//고양이
            Console.WriteLine("\\    /\\\n )  ( ')\n(  /  )\n \\(__)|");
*/
            /*//개
            Console.WriteLine("|\\_/|\n|q p|   /}\n( 0 )\"\"\"\\\n|\"^\"`    |\n||_/=\\\\__|");
*/
            /*//구구단
            int a = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{a} * {i} = {i * a}");
            }
*/

            /*//두 수 비교하기
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            if (array[0] > array[1])
                Console.WriteLine(">");
            else if(array[0] < array[1])
                Console.WriteLine("<");
            else if (array[0] == array[1])
                Console.WriteLine("==");
*/

            /*//시험 성적
            int record = int.Parse(Console.ReadLine());

            if (record <= 100 && record >= 90)
                Console.WriteLine("A");
            else if(record <= 89 && record >= 80)
                Console.WriteLine("B");
            else if (record <= 79 && record >= 70)
                Console.WriteLine("C");
            else if (record <= 69 && record >= 60)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
*/
            /*//윤년
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
*/

            /*//사분면 고르기
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine(1);
            else if(x < 0 && y > 0)
                Console.WriteLine(2);
            else if (x < 0 && y < 0)
                Console.WriteLine(3);
            else if (x > 0 && y < 0)
                Console.WriteLine(4);
*/

            /*//알람 시계
            int[] time = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int H, M = 0;

            if (time[1] >= 45)
                Console.WriteLine($"{time[0]} {time[1] - 45}");
            else if (time[0] > 0 && time[1] < 45)
            {
                M = time[1] - 45;
                Console.WriteLine($"{time[0] - 1} {60 + M}");
            }
            else if (time[0] == 0 && time[1] < 45)
            {
                H = time[0] + 23;
                M = time[1] - 45;
                Console.WriteLine($"{H} {60 + M}");
            }
*/

            /*//오븐 시계 https://www.acmicpc.net/source/85541799 if문 안쓰고
            string[] time = Console.ReadLine().Split(' ');
            int T = int.Parse(Console.ReadLine());

            int H = int.Parse(time[0]);
            int M = int.Parse(time[1]);

            int h = T / 60;ㄴ
            int m = T % 60;

            if (H + h > 23 && M + m > 59)
            {

                Console.WriteLine($"{H + h - 23} {M + m - 60}");

            }
            else if (H + h > 23)
            {
                Console.WriteLine($"{H + h - 24} {M + m}");
            }
            else if (M + m > 59)
            {
                if(H + h == 23)
                    Console.WriteLine($"{0} {M + m - 60}");
                else
                    Console.WriteLine($"{H + h + 1} {M + m - 60}");
            }
            else
            {
                Console.WriteLine($"{H + h} {M + m}");
            }
*/

            //주사위 세개
            /*int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            
            if (a[0] == a[1] && a[1] == a[2])
            {
                Console.WriteLine(10000 + a[0] * 1000);
            }
            else if (a[0] == a[2])
            {
                Console.WriteLine(1000 + a[0] * 100);
            }
            else if (a[2] == a[1])
            {
                Console.WriteLine(1000 + a[1] * 100);
            }
            else if (a[0] == a[1])
            {
                Console.WriteLine(1000 + a[0] * 100);
            }
            else
            {
                if(a[0] > a[1] && a[0] > a[2])
                    Console.WriteLine(a[0] * 100);
                else if (a[2] > a[1] && a[2] > a[0])
                    Console.WriteLine(a[2] * 100);
                else if (a[1] > a[0] && a[1] > a[2])
                    Console.WriteLine(a[1] * 100);
            }
*/

            /*//A+B - 3
            int T = int.Parse(Console.ReadLine());

            for(int i = 0; T > i;  i++)
            {
                int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Console.WriteLine(array[0] + array[1]);

            }
*/

            /*//합
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for(int i = 0; a >= i; i++)
            {
                sum += i;
                //Console.WriteLine(i);

            }
            Console.WriteLine(sum);
*/

            /*//영수증
            int price = int.Parse(Console.ReadLine());
            int quantity = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 0; quantity > i; i++)
            {
                int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                sum += b[0] * b[1];
            }

            if(price == sum)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
*/
            /*//코딩은 체육과목 입니다
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; count > i; i++)
            {
                if(i % 4 == 0)
                Console.Write("long ");
            }
            Console.WriteLine("int");
*/
            /*//빠른 A+B
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

            int T = int.Parse(Console.ReadLine());
            int[] count = new int[T];

            for (int i = 0; T > i; i++)
            {
                int[] number = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                count[i] = number[0] + number[1];

            }

            foreach (var i in count)
            {
                Console.WriteLine(i);
            }
            
            Console.Out.Flush();
*/

            /*//A+B - 7
            int T = int.Parse(Console.ReadLine());

            for(int i = 0; T > i; i++)
            {
                int[] count = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Console.WriteLine($"Case #{i+1}: {count[0] + count[1]}");
            }
*/
            /*//A+B - 8
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; T > i; i++)
            {
                int[] count = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Console.WriteLine($"Case #{i + 1}: {count[0]} + {count[1]} = {count[0] + count[1]}");
            }
*/
            /*//별 찍기 - 1
            int T = int.Parse(Console.ReadLine());

            for(int i = 0; T > i; i++)
            {

                for(int j = 0; i >= j; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
*/
            /*//별 찍기 - 2
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; N > i; i++)
            {

                for (int j = N; j > i+1; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; i >= j; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
*/
            /*//A+B - 5
            int a;
            while (true)
            {
                int[] number = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                a = number[0] + number[1];

                if(a != 0)
                {
                    Console.WriteLine($"{number[0] + number[1]}");
                }
                else
                    return;
            }
*/

            /*//A+B - 4
            while (true)
            {
                int[] number = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                if (number == null)
                    break;
                Console.WriteLine($"{number[0] + number[1]}");

            }
*/
            /*//개수 세기
            int N = int.Parse(Console.ReadLine());
            int[] count = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int v = int.Parse(Console.ReadLine());

            int sum = 0;

            foreach (int i in count)
            {
                if(i == v)
                    sum++;
            }

            Console.WriteLine(sum);
*/
            /*//X보다 작은 수
            int[] N = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            foreach (var count in A)
            {
                if(count < N[1])
                {
                    Console.Write($"{count} ");
                }
            }
*/
            //최소, 최대

            #region [최적화 전]
            /*
                        int N = int.Parse(Console.ReadLine());

                        int max = 0, min = 0;

                        string[] u = Console.ReadLine().Split(' ');
                        int[] t = new int[N];

                        for (int i = 0; i < N; i++)
                        {
                            t[i] = int.Parse(u[i]);

                            if (i == 1)
                            {
                                max = Math.Max(t[i - 1], t[i]);

                                min = Math.Min(t[i - 1], t[i]);
                            }
                            else if(i > 0)
                            {
                                max = Math.Max(max, t[i]);

                                min = Math.Min(min, t[i]);
                            }
                        }

                        Console.WriteLine($"{min} {max}");
            */
            #endregion
            /*
                        int N = int.Parse(Console.ReadLine());

                        int[] d = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                        int max = int.MinValue;
                        int min = int.MaxValue;

                        for (int i = 0; N > i; i++)
                        {
                            max = Math.Max(d[i], max);
                            min = Math.Min(d[i], min);
                        }

                        Console.WriteLine($"{min} {max}");
*/

            /*//최댓값
            int[] a = new int[9];
            int max = int.MinValue;

            for (int i = 0; a.Length > i; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                max = Math.Max(max, a[i]);
            }

            Console.WriteLine($"{max} {Array.IndexOf(a, max)+1}");
*/

            //공 넣기
            #region[문제랑 출력이 똑같지만 실패]
            /*
                        int[] count = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                        int[] N = new int[count[0]];

                        foreach (int i in N)
                        {
                            N[i] = 0;
                        }


                        for (int i = 0; N.Length > i; i++)
                        {
                            try
                            {
                                int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                                for (int j = array[0]; j <= array[1]; j++)
                                {
                                    N[j - 1] = array[2];

                                }

                                //foreach (int w in N)
                                //{
                                //    Console.Write($"{w} ");
                                //}

                            }
                            catch
                            {
                                N[i] = 0;
                            }

                        }

                        foreach (int i in N)
                        {
                            Console.Write($"{i} ");
                        }
            */
            #endregion
            /*
                        int[] count = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        int[] N = new int[count[0]];
                        int M = count[1];

                        for (int i = 0; i < N.Length; i++)
                        {
                            N[i] = 0;
                        }

                        for (int i = 0; i < M; i++)
                        {
                            int[] change = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                            int Max = Math.Max(change[0], change[1]);
                            int Min = Math.Min(change[0], change[1]);
                            Max -= 1;
                            Min -= 1;

                            for (; Min <= Max; Min++)
                            {
                                N[Min] = change[2];
                            }

                        }

                        foreach (int i in N)
                        {
                            Console.Write($"{i} ");
                        }
            */

            /*//공 바꾸기

            int[] count = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] N = new int[count[0]];
            int M = count[1];

            for (int i = 0; i < count[0]; i++) //for문의 i를 ++i로 하면 i에 영향이 가서 만약 count[0] = 5면 1, 3, 5 이렇게 3번 밖에 실행 안됨
            {
                N[i] = i + 1;

            }

            for (int i = 0; i < M; i++)
            {
                int[] change = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                change[0] = change[0] - 1;
                change[1] = change[1] - 1;

                int load = N[change[0]];
                N[change[0]] = N[change[1]];
                N[change[1]] = load;

            }

            foreach (int i in N)
            {
                Console.Write($"{i} ");
            }
*/

            //과제 안 내신 분..?

            /*//리스트
            List<int> list = new List<int>();

            for (int i = 0; i < 28; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < 30; i++)
            {
                if(!list.Contains(i+1))
                {
                    Console.WriteLine(i + 1);
                }

            }
*/

            /*//배열
            int[] array = new int[28];

            for (int i = 0; i < 28; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 30; i++)
            {
                if (!Array.Exists(array, x => x == i + 1))
                {
                    Console.WriteLine(i + 1);
                }

            }
*/

            /*//나머지 (브론즈2)
            List<int> list = new List<int>();
            int count = 0, Max = -1;


            for (int i = 0; i < 10; i++)
            {
                int a = int.Parse(Console.ReadLine());
                list.Add(a % 42);
            }

            list.Sort();

            foreach (int item in list)
            {

                if (Max < item)
                {
                    Max = Math.Max(Max, item);
                    ++count;
                }
            }

            Console.WriteLine(count);
*/

            /*//바구니 뒤집기
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] N = new int[a[0]];
            int M = a[1];

            for (int i = 0; i < N.Length; i++)
            {
                N[i] = i+1;
            }

            for (int i = 0; i < M; i++)
            {
                int[] Change = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int Max = Math.Max(Change[0], Change[1]);
                int Min = Math.Min(Change[0], Change[1]);
                Min -= 1;
                int Length = Max - Min;

                Array.Reverse(N, Min, Length);             
            }

            foreach (var item in N)
            {
                Console.Write($"{item} ");
            }
*/
            /*//평균
            double count = double.Parse(Console.ReadLine());
            double Max = double.MinValue;

            double[] score = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

            for (int i = 0; i < count; i++)
                Max = Math.Max(Max, score[i]);

            for (int i = 0; i < count; i++)
            {
                score[i] = score[i] / Max * 100;
            }

            Console.WriteLine(score.Average());
*/
            /*//문자와 문자열   
            string word = Console.ReadLine();
            int order = int.Parse(Console.ReadLine());
            Console.WriteLine(word[order-1]);
*/

            /*//단어 길이 재기
            Console.WriteLine(Console.ReadLine().Length);
*/

            /*//문자열
            int order = int.Parse(Console.ReadLine());
            int i = 0;
            while (i++ < order)
            {
                string word = Console.ReadLine();
                Console.WriteLine(word.Substring(0, 1) + word.Substring(word.Length - 1, 1));
                Console.WriteLine(word[0] + "" + word[word.Length-1]);
            }
*/
            /*//아스키 코드
            char ASCII = char.Parse(Console.ReadLine());
            //int e = Convert.ToInt32(a); //Convert 변수 변환 함수(좀더 세세한 조정 가능한 듯)

            Console.WriteLine((int)ASCII);

            Console.WriteLine((int)char.Parse(Console.ReadLine()));
            Console.WriteLine((int)Console.ReadLine()[0]);
            int ASCII = Console.Read(); //문자 코드 값
*/
            /*//숫자의 합
            int count = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            int Sum = 0;
            foreach (var i in number)
                Sum += i - '0';
            Console.WriteLine(Sum);
*/
            /*//알파벳 찾기
            string word = Console.ReadLine();
            List<int> alphabet = new List<int>();
            List<int> check = new List<int>();
            int save = -1;

            for (int i = 0; i < 26; i++)
                alphabet.Add(-1);

            for (int i = 0; i < word.Length; i++)
            {
                check.Add(word[i]);

                if (2 > check.Where(a => a == word[i]).Count())
                {
                    alphabet[word[i] - 'a'] = i;
                }

            }

            foreach (int i in alphabet)
                Console.Write($"{i} ");
*/

            /*            var input = Console.ReadLine();

                        var res = Enumerable.Repeat(-1, 26).ToArray();
                        foreach (var item in res)
                        {
                            Console.WriteLine(item);
                        }*/

            /*//문자열 반복

            int count2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < count2; i++)
            {
                string[] count = Console.ReadLine().Split(' ');

                foreach (char word in count[1])
                {
                    for (int j = 0; j < int.Parse(count[0]); j++)
                    {
                        Console.Write(word);
                    }
                }
                Console.WriteLine("");
            }
*/

            /*//단어의 개수
            string[] a = Console.ReadLine().Trim().Split(' ');
            Console.WriteLine(String.IsNullOrWhiteSpace(a[0]) ? 0 : a.Length);


            foreach (string s in a)
            {
                if(String.IsNullOrWhiteSpace(s))
                    Console.WriteLine(0);
                else
                    Console.WriteLine(a.Length);
            }
*/
            /*//상수

            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] sum = new int[2];
            int max = 0;

            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum[i] *= 10;
                    sum[i] += array[i] % 10;
                    array[i] /= 10;
                }
            }
            Console.WriteLine(sum[0] > sum[1] ? sum[0] : sum[1]);
*/

            /*//다이얼 잘한 사람 https://www.acmicpc.net/source/83878213, https://www.acmicpc.net/source/82933191

            string word = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'A' || word[i] == 'B' || word[i] == 'C')
                    sum += 3;
                
                else if (word[i] == 'D' || word[i] == 'E' || word[i] == 'F')
                    sum += 4;
                
                else if (word[i] == 'G' || word[i] == 'H' || word[i] == 'I')
                    sum += 5;
                
                else if (word[i] == 'J' || word[i] == 'K' || word[i] == 'L')
                    sum += 6;
                
                else if (word[i] == 'M' || word[i] == 'N' || word[i] == 'O')
                    sum += 7;
                
                else if (word[i] == 'P' || word[i] == 'Q' || word[i] == 'R' || word[i] == 'S')
                    sum += 8;
                
                else if (word[i] == 'T' || word[i] == 'U' || word[i] == 'V')
                    sum += 9;
                
                else if (word[i] == 'W' || word[i] == 'X' || word[i] == 'Y' || word[i] == 'Z')
                    sum += 10;
                
            }
            Console.WriteLine(sum);
*/
            //그대로 출력하기

            /*            List<string> a = new List<string>();
                        string asd;

                        while(true)
                        {
                            if (string.IsNullOrEmpty(asd = Console.ReadLine()))
                                break;

                            a.Add(asd);
                        }

                        foreach (var item in a)
                        {
                            Console.WriteLine(item);
                        }
            */

            //책 페이지
            /*
                        int pages = int.Parse(Console.ReadLine());

                        int[] arr = new int[10];

                        for (int i = 0; i < pages; i++) // 페이지 수만큼 반복
                        {
                            for (int j = 0; j < arr.Length; j++) // 0 ~ 9까지 반복
                            {
                                string ary = i.ToString();

                                for (int k = 0; k < ary.Length; k++) //현재 페이지의 문자열 길이 만큼 반복
                                {
                                    if (ary[k] - 48 == j && j + 1 != 10)// 아스키 코드 48 = 0, 49 = 1 ... 56 = 8, 57 = 9 이므로 48을 빼서 아스키코드에서 숫자로 만들어줌
                                        arr[j + 1]++;
                                    else if (ary[k] - 48 == j && j + 1 == 10)
                                        arr[9]++;
                                }                     
                            }
                        }

                        foreach (var item in arr)
                        {
                            Console.Write(item + " ");
                        }
            */ 

            //300 x 9 + 189 전 값
/*
            int pages = int.Parse(Console.ReadLine());

            int[] arr = new int[10];

            for (int i = 0; i < pages; i *= 10)
            {

                Console.WriteLine();
            }
*/

            //새싹
            //Console.Write("         ,r\'\"7\nr`-_   ,\'  ,/\n \\. \". L_r\'\n   `~\\/\n      |\n      |");


            //킹, 퀸, 룩, 비숍, 나이트, 폰

        }
    }
}
