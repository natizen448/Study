using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c#은 고지식한 객체지향 언어
//클래스밖에 모르는 바보.
//프로그램의 시작조차도
//클래스 안에 묶어놔야한다.


    class Player
    {//멤버변수 -> 클래스 내부에 있다고 해서 멤버변수.
    int Att;
    int Hp;

    void Fight()
    {
        //선언되는 순간 메모리화되고 
        Console.WriteLine("플레이어가 싸운다.");
    }
    }
    //게임에서 사용하기위해 여기까지 설계했다.

    class _05LocalVar
    {
    //시작용 함수
        static void Main(string args)
        {
        //클래스 안에있으면 멤버변수
        //함수안에 있으면 지역변수라고 한다.
        //지역변수 규칙
        //{
        //  내부에서만 사용한다
        //}

        
        int ATT;
        ATT = 0;


        //객체화라고 하는 중요한 작업.
        //클래스를 뭐라고 하는가?
        //설계도.
        //Player의 설계대로 플레이어를 만드는데.
        //그 이름을 newPlayer라고 해라. 
        Player newPlayer = new Player();
           
        }
    }
//https://www.youtube.com/watch?v=-JD5ry7P1iU&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=8

