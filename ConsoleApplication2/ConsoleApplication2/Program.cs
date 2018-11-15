using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using - 다른 네임 스페이스에 정의된 타입을 import하거나, 네임스페이스에 대해 별칭을 만들 때 사용

namespace ConsoleApplication2
{
    // namespace는 동일한 이름의 클래스명을 만든 소스를 구분할 수 있는 역할을 한다. 클래스의 소속명 (패키지)
    class Program
    {
        class Student
        {
            public string name;
            public int grade;
            //밑에 리스트와 모델클래스 동시 초기화 하는법에 쓰임
        }


        static void Main(string[] args)
        {
            Console.WriteLine("콘솔에 출력하기");

            //코드 실행중에 에러 -> 예외, 런타임에러

            Console.WriteLine(52 < 46); //False

            //자료형의 범위를 넘어버리면 오버플로우

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue); //int의 최대값과 최소값

            Console.WriteLine(sizeof(int)); //몇바이트인지 알려줌
            Console.WriteLine(sizeof(double));

            string message = "안녕하세요";
            Console.WriteLine(message[1]); //[]안의 인덱스 값이 나옴

            Console.WriteLine(message.GetType()); //타입검사

            //var는 지역변수(메서드내부), 선언과 동시에 초기화

            string input = Console.ReadLine();
            Console.WriteLine(input);

            Console.WriteLine(int.Parse("44")); //문자열을 int로 형변환
            Console.WriteLine(float.Parse("33.33"));

            Console.WriteLine((54).ToString()); //문자열로 형변환
            Console.WriteLine(('a').ToString());

            double number = 32.3423673;
            Console.WriteLine(number.ToString("0.00")); //소수점제거 !!!!
            Console.WriteLine(number.ToString("0.00000"));

            int input2 = int.Parse(Console.ReadLine()); //입력받은 숫자 int로 parse하기 !!!
            if (input2 % 2 == 0)
            {
                Console.WriteLine("짝수입니다");
            }
            else if (input2 % 2 == 1)
            {
                Console.WriteLine("홀수입니다");
            }
            else
            {
                Console.WriteLine("둘다아닙니다");
            }

            Console.WriteLine(DateTime.Now); //지금 시간
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            switch (input2%2)
            {
                case 0:
                    Console.WriteLine("짝수입니다");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다.");
                    break;
            }
            // switch 외우기 !!

            int number2=2;
            Console.WriteLine(number2 % 2 == 0 ? true : false);
            Console.WriteLine(number2 % 2 == 0 ? "짝수" : "홀수");
            //삼항연산자 ~~~

            string line = Console.ReadLine();
            if (line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요!");
            }
            //contains 메서드 true false값으로 리턴

            ConsoleKeyInfo info = Console.ReadKey(); //키보드로 입력한 키를 받아옴
            switch (info.Key)
            {
                case ConsoleKey.A:
                    Console.WriteLine("A를 눌렀어요");
                    break;
                case ConsoleKey.B:
                    Console.WriteLine("S를 눌렀어요");
                    break;
            }
            //키 입력받은 조건으로

            //배열 !!!
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            int[] array = new int[100]; //원하는 크기의 배열생성
            array[0] = 1;
            Console.WriteLine(array[0]);

            int i = 0;
            int[] intArray1 = {23,434,65,345,5};
            while (i<intArray1.Length)
            {
                Console.WriteLine(i + "번째출력." + intArray1[i]);
                i++;
            }

            foreach (var item in intArray1) //포이치 사용범 ~!!!!
            {
                Console.WriteLine(item);
            }

            while (true)
            {
                int whil = 1;
                if(whil==1){
                    break;
                    //continue; 는 반복을 아예 나가지 않고 조건에 걸리면 다음반복으로 넘어감.
                }
            } // 무한반복에서 조건걸어서 break로 나오기

            
            //이런 클래스 이름으로 곧바로 사용하는 변수와메서드를 큰래스변수와 클래스메서드라고 한다.
            //클래스의 사용
            //랜덤 인스턴스를 만들고 .으로 인스턴스멤버를 사용함 (인스턴스멤버 - 메서드,변수,속성)
            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));

            
            
            //List클래스 C#에서 가장 중요 !!!!!!!!!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //list는 크기가 가변적인 배열을 만든다
            // <>으로 미리 타입을 정해주는걸 제네릭 ! 이라고함.
            List<int> list = new List<int>();
            //List<int> list = new List<int>(){32,432,43,532,54); 도 가능.
            list.Add(52);
            list.Add(33);
            list.Add(48);

            list.Remove(40); // 요소 빼기
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }



            //리스트와 모델클래스 동시 초기화
            List<Student> list1 = new List<Student>(){
                new Student(){name="윤인성",grade=1},
                new Student(){name="rlaqu",grade=4},
                new Student(){name="이라너",grade=6},
                new Student(){name="온스민",grade=4},
                new Student(){name="김병관",grade=19}
            };

            foreach (var item in list1)
            {
                Console.WriteLine(item.name + item.grade);
            }

            //메서드만들기
            //public int Multiple(int min, int max){
           //     int result = min * max;
           //     return result;
           // }



            //오버로딩 읾은같고, 매개변수는 다른 메서드
            //이름을 같게 , 매개변수를 다르게,, 반환값은 상관없음

            //public , private

            //const
            const double PI = 3.1449530;

            //읽기전용 readonly 도 잇음

            //이클립스는 ctrl + d / VS는 ctrl + shift + l

            //이클립스는 ctrl + alt + ↓ / VS는 복사하고자 하는 라인에서 영역을 선택하지 않은 상태로 ctrl + c 후 다시 ctrl + v

            
            //public int MyProperty { get; set; } //prop 입력후 탭탭

            //컬렉션 - 데이터모음(자료구조) - 배열이나 스택, 큐

            
            //상속 - class Dog : Animal //

            //public 모두가능, internal 내부외부클래스 파생클래스, potected 내부클래스 파생클래스, private 내부클래스 , 

            //this 는 본인키워드, base는 부모 키워드

            //다형성 - 자식클래스가 부모클래스로 위장하는것, 외관상으로 부모객체이므로 사용할수 있는 멤버는 부모클래스의 멤버뿐.
            // 자식 멤버를 호출하려면 자료형 변환 해야함.
            //Object가 최상위 클래스 Object로 다형성 해도됨 , 부모클래스 위에 Object라서
            //어떤 클래스인지 ㅇ확인할때는 is, if랑 같이씀 if(item is Dog){} 이런식으로




            
            



            














        }
    }
}
