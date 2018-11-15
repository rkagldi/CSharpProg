using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCShartWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        
        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void ultraLabel1_Click(object sender, EventArgs e)
        {

            int number1 = 10;
            string operator1 = "+";
            bool isCorrect = true; //false;

            // +, -, *, /
            int sum = 1 + 2;

            int one = 1;
            int two = 2;
            int sum2 = one + two;

            HelloLabel.Text = sum2.ToString(); // string형으로 바꾸는 메서드
            // UI => user interface
        }

        private void sumNumbers_Click(object sender, EventArgs e) //이것도 function
        {

            int number1 = 0;
            int number2 = 0;
           
            if(string.IsNullOrWhiteSpace(sum1.Text)) //IsNullOrWhiteSpace => null, 스페이스키,탭, 등 공백문자 bool로 리턴;
            {
                MessageBox.Show("sum1에 숫자를 입력해주세요 !");
                sum1.Focus();
                return;
            }

            if(int.TryParse(sum1.Text, out number1)==false) //sum1에 text를 숫자일경우 number1에 그 숫자를 넣음
            {
                MessageBox.Show("sum1에 문자가 들어왔습니다, 숫자를 입력해주세요.");
                sum1.Focus();
                sum1.SelectAll();
                return;
            }

            if (string.IsNullOrWhiteSpace(sum2.Text)) //IsNullOrWhiteSpace => 스페이스키,탭, 등 공백문자 bool로 리턴;
            {
                MessageBox.Show("sum2에 숫자를 입력해주세요 !");
                sum2.Focus();
                return;
            }

            if (int.TryParse(sum2.Text, out number1) == false) //sum2에 text를 숫자일경우 number1에 그 숫자를 넣음
            {
                MessageBox.Show("sum2에 문자가 들어왔습니다, 숫자를 입력해주세요.");
                sum2.Focus();
                sum2.SelectAll();
                return;
            }


            number1 = Convert.ToInt32(sum1.Text);
            number2 = Convert.ToInt32(sum2.Text);

            int sum = Add(number1,number2);
            sumResult.Text = sum.ToString();
        
            //유효성검사 해야함. 숫자가 아닐수도 있고 빈칸이 올 수도 있으니// validation??
            //함수 = function = 메서드(클래스에 속한 함수) 
            //C#에서 모든 function는 클래스에 속해있다

        }
            public int Add(int number1, int number2)
            {
                int sum = number1 + number2;
                return sum;
            }
        public float Add(float number1, float number2)
        {
            float sum = number1+number2;
            return sum;
        }

        //오버로딩 = 함수이름은 같고 매개변수는 다른것 , 타입이든 갯수든, 위의 함수의 이름이 add로 같은것.

        public int sub(int number1 , int number2)
        {
            int sub = number1 - number2;
            return sub;
        }

    }
}
