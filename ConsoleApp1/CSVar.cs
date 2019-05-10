using System;

namespace ConsoleApp1
{
    public class CSVar
    {
        int globalVar;
        const int MAX = 1024;

        private readonly int max; //readonly 키워드는 메소드안에서 선언x

        public CSVar() //생성자 리턴타입x
        {
            max = 1;
            
        }
        
        public void Method1()
        {
            int localVar;

            localVar = 100;
                
            Console.WriteLine("global Variable : "+globalVar);
            Console.WriteLine("local Variable : "+localVar);
            //필드 glovalVar이라는 값을 명시적으로 할당하지 않은 경우 기본값 0이 할당
            //지역변수 localVar이라는 값을 할당하지 않고 사용하게 되면, 컴파일러 에러가 발생
            
            //상수는 중간에 값을 변경할 수 없다.
            //const 대신 readonly 키워드를 사용하여 읽기전용 필드를 만들 수 있다. 

            const int MAX_VALUE = 1024;
            
            
        }
    }
}