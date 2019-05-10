using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //bool
            bool b = true;

            //numeric
            short sh = -32768;
            int i = 2147483647;
            long l = 1234L; //l Suffix
            float f = 123.45F; //F Suffix
            double d1 = 123.45D; //D Suffix
            double d2 = 123.45;
            decimal d = 123.45M; // M은 decimal type

            // Char/String
            char c = 'A';
            string s = "string ex";

            // DateTime 2011-10-30 12:35
            DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);

            Console.WriteLine(b + " " + sh + " " + i + " " + l + " " + f + " " + d1 + " " + d2 + " " + d + " " + c +
                              " " + s);

            int maxi = int.MaxValue;
            float minf = float.MinValue;

            Console.WriteLine(int.MaxValue + "  " + float.MinValue);
            Console.WriteLine("-------------------------------------------------");

            //nullable type
            int? nullableI = null;
            i = 101;

            bool? nullableB = null;

            //int? 를 int로 할당
            Nullable<int> nullableType = null;
            nullableType = 10;
            int nullableIntAssignment = nullableType.Value;

            // variable example
            CSVar CSVarObj = new CSVar();
            CSVarObj.Method1();
            
            //1차 배열
            string[] players = new string[10];
            string[] Regions = {"서울", "경기", "부산"};
            
            // 2차 배열 선언 및 초기화
            string[,] Depts = {{"김과장", "경리부"},{"이과장", "총무부"}};
            
            // 3차 배열 선언
            string[,,] Cubes;
            
            //Jagged Array (가변 배열)
            //1차 배열 크기(3)는 명시해야
            int[][] A = new int[3][];
            
            //각 1차 배열 요소당 서로 다른 크기의 배열 할당 가능
            A[0] = new int[2];
            A[1] = new int[3]{1,2,3};
            A[2] = new int[4]{1,2,3,4};

            A[0][0] = 1;
            A[0][1] = 2;

            for (int j = 0; j < Regions.Length; j++)
            {
                Console.Write(Regions[j]+" ");
            }
            Console.WriteLine();
            
            //array는 reference type
            int[] scores = {80,70,60,90,100};
            Console.WriteLine(CalculateSum(scores));
            
            //C#의 키워드 string은 .NET의 System.String 클래스와 동일하며, 따라서 System.String 클래스의 모든 메서드와 속성을 사용할 수 있음.
            string csharp = "C#";
            string programming = "Programming";
            
            //문자 (char) 변수
            char charA = 'A';
            char charB = 'B';
            
            //문자열의 결합
            string concatenate = csharp + " " + programming;
            Console.WriteLine("String : {0}", concatenate);
            
            //부분문자열 발췌
            Console.WriteLine("Substring : {0}",concatenate.Substring(1, 5));

            string csharpV = "C# Studio";
            
            //문자열을 배열인덱스로 한문자 액세스
            for (int j = 0; j < csharpV.Length; j++)
            {
                Console.WriteLine("{0} : {1}",j,csharpV[j]);
            }
            
            //문자열을 문자배열로 변환
            string str = "hello";
            string[] strArr = new string[6];

            Category myCategory;
            
            //enum 타입에 값을 대입하는 방법
            myCategory = Category.Bread;
            Console.Write("Category.Bread : " + myCategory);
            
            //enum을 int로 변환(Casting)하는 방법
            // (int)를 앞에 지정
            int BreadValue = (int)myCategory;
            Console.Write("enum의 bread 숫자 : "+ BreadValue);

            if (myCategory == Category.Bread)
            {
                Console.WriteLine("enum 타입의 숫자와 (int)로 casting한 값이 일치");
            }
            
            //OR연산자로 다중 플래그 할당
            Border FlagsOr = Border.Top | Border.Bottom;
            
            //& 연산자로 플래그 체크
            if ((FlagsOr & Border.Top) != 0)
            {
                //HashFlag()이용 플래그 체크
                if (FlagsOr.HasFlag(Border.Bottom))
                {
                    Console.WriteLine(FlagsOr);
                }
            }

            if (args.Length != 1)
            {
                Console.WriteLine("Usage : MyApp.exe option");
                return;
            }

            string option = args[0];
            switch (option.ToLower())
            {
                case "/v":
                    case "/verbose":
                    verbose = true;
                    break;
                    case "/c":
                        continueOnError = true;
                        break;
                    case "/l":
                        logging = true;
                        break;
                    default:
                        Console.WriteLine("unknown argument : {0}", option);
                        break;
            }

            string[] strArray = new string[]{"a","b","c"};
            
            //foreach 루프
            foreach (string VARIABLE in strArray)
            {
                Console.WriteLine(VARIABLE);
            }

            //3차배열 선언
            string[,,] ThreeDarr = new string[,,]
            {
                {{"1","2"},{"3","4"},{"5","6"},{"7","8"}}
            };

            for (i = 0; i < ThreeDarr.GetLength(0); i++)
            {
                for (int j = 0; j < ThreeDarr.GetLength(1); j++)
                {
                    for (int k = 0; k < ThreeDarr.GetLength(2); k++)
                    {
                        Console.WriteLine(ThreeDarr[i,j,k]);
                    }
                }
            }

            foreach (var foreachVariable in ThreeDarr)
            {
                Console.WriteLine(foreachVariable);
            }
            

        }

        static int CalculateSum(int[] scoresArray)
        {
            int sum = 0;
            for (int i = 0; i < scoresArray.Length; i++)
            {
                sum += scoresArray[i];
            }

            return sum;
        }
        
             
        public enum Category // 상수 숫자들을 보다 의미있는 단어들로 표현
        {
            Cake,
            IceCream,
            Bread
        }

        [Flags] //속성 지정가능
        enum Border
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8
        }

        private static bool verbose = false;
        private static bool continueOnError = false;
        private static bool logging = false;
    }
}