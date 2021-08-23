using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//여러분이 왜 메모리를 알아야하는가
//메모리란 사실 c#을 배워야 하기 때문에 알아야 하는게 아니라
//c#이 아니라 모든 프로그래밍의 근간이 되는 개념이기 때문이다.
//이 말은 무슨 말이냐?
//모든 프로그램은
//공짜는 없다. 메모리를 지불한다.
//메모리의 구조를 안다는것은 
//코드의 동작원리를 아는것과 같다.

class Player
{
    int HP = 100;
    int AT = 10;
    
    //함수의 인자값은 
    //지역변수이다.
    //지역변수의 특징
    //함수가 끝나면 사라진다.
    public void Damage(int _Dmg)
    {

    }
}
class Program
{   //이녀석을 메인 함수라고 하는데.
    //static을 빼면 함수의 모양을 가지고 있고.
    //함수
    //이곳을 시작이라고 잡은 함수
    //c#의 규칙 Main 이라는 이름의 함수에서부터 시작한다.
    //함수의 실행조차 공짜가 없다
    static void Main()
    {
        //함수는 메모리화 되지않는다.

        //지역변수 + a 로 계산되는데
        //최소한 지역변수를 다 포함할 수 있는 크기만큼은
        //되어야한다.

        //객체를 만들었다.
        //객체를 만들었다는 것은 메모리를 지불했다는 것.
        //좀더 근본적인 내용은 무엇이냐?
        //단 하나도 공짜가 없다.
        Player NewPlayer = new Player();
        //이게 프로그램의 라이프 사이클
    }
}
