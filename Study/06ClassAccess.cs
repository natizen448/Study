using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{//->클래스의 내부
   
    //객체지향의 캡슐화 은닉화를 대표하는 문법
    //접근제한 지정자입니다.
    public int Att;//외부에도 공개
    protected int HP;//자식에게만 공개
    private int Def;//내부에만 공개

    void Fight()
    {

    }
}//->클래스의 끝

//-> 클래스의 외부

    class _06ClassAccess
    {
    static void Main(string[] args)
    {
        Player newPlayer = new Player();
        //만들어진 객체의 내용을 사용하기 위해서는
        //객체의이름. 을 사용한다
        //접근제한 지정자라는 문법을 사용하지않아서.
        //외부에 공개하지 않기로 했다.

        //잘못쓰기도 힘들게 만들어놔라.
        newPlayer.Att = 1000;
    }
    }

//https://www.youtube.com/watch?v=-JD5ry7P1iU&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=8

