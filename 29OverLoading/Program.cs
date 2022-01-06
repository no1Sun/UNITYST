using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum DMGTYPE
{
    PYDMG,
    FIREDMG,
    ICEDMG
}

class Player
{

  
    //
    int AttDef = 5;
    int FireDef = 5;
    int IceDef = 5 ;

    int HP = 100;

    public Player()
    {

    }

    public Player(int _HP)
    {
        HP = _HP;
    }
    static void Func(int _Value)
    {

    }


    public void Damage(int _Damage)
    {

    }


    public void Damage(float _Damage)
    {

    }

    public void Damage(float _Damage, int _Type)
    {

    }

    public void Damage(int _Damage, DMGTYPE _Type)
    {
        switch(_Type)
        {
            case DMGTYPE.PYDMG:
                _Damage -= AttDef;
                break;
            case DMGTYPE.FIREDMG:
                _Damage -= FireDef;
                break;
            case DMGTYPE.ICEDMG:
                _Damage -= IceDef;
                break;

            default:
                break;
        }
        Damage(_Damage);
    }
}

namespace _29OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player(1000);
            NewPlayer.Damage(100, DMGTYPE.FIREDMG);
        }
    }
}
