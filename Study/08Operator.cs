using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int HP = 100;
    void Damage(int _HP)
    {
        HP = HP - 10;
    }
    public int Plus(int _Left, int _Right)
    {
        int Result = _Left + _Right;
        return Result;
    }
}
namespace Study
{
    class _08Operator
    {
        static void Main(string[] args) {

            Player NewPlayer = new Player();
            int Result = 0;
            int Left = 7;
            int Right = 3;

            // = 대입연산자.
            //함수에서 리턴된 값이나
            //혹은 연산이된 값을 
            //리터럴 값일때도 있다
            //그 값을 받을 수 있는 변수에
            //넣어줘라

            //산술연산자
            //리턴값이라는 것은
            //외부에 연산값이나 객체 상태값
            //등을 끝내고 나면 외부에 반환하는 것을 말하고
            //이런식으로 = 연산자가 있다면
            //연산자의 우선순위라고 하는데.
            //
            Result = NewPlayer.Plus(Left, Right); //Left + Right;//더하기
            Result = Left - Right;//빼기
            Result = Left * Right;//곱하기
            Result = Left / Right;//나누기
            Result = Left % Right;//나머지
            //()연산자는 연산자의 실행순서를 내가 지정해줄 수 있게된다.
            //이런식으로 
            //산술 연산을 할 수 있고
            //한가지 주의할 점은
            //나누기와 나머지는 0을 넣으면 안된다.
            //10 / 0 은? 수학에서 불가능하다
            //컴퓨터에서는 제로디비전이라고 해서 오류가 난다.
            //프로그램이 실행도중 터질정도의 오류이므로
            //주의하셔야합니다

            //연산자는 함수와 비슷합니다
            
            //비교연산자.
            //비교연산자는 논리형으로 리턴되는데

            //논리형 bool이라는 녀석.
            //bool은 참과 거짓이 있게되는데 
            //참과 거짓이 상수화 된것이
            //true와 false이다.

            bool Bresult = true;

            //이런식으로 참과 거짓을 통해서
            Bresult = Left > Right; //Left가 Right보다 큰가? 참이라면 true 거짓이라면 false를 리턴한다.
            Bresult = Left < Right; //Left가 Right보다 작은가?
            Bresult = Left <= Right;//Left가 Right보다 작거나 같은가?
            Bresult = Left >= Right;//Left가 Right보다 크거나 같은가?
            Bresult = Left == Right;//Left와 Right이 같은가?
            Bresult = Left != Right;//Left와 Right이 같지않은가?






        }
    }
}
