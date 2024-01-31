using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 최상위 아이템 추상 클래스
public abstract class Item 
{
    public string name;

    public abstract void Operate();

    public Item(string _name)
    {
        this.name = _name;
        Debug.Log("아이템 : " + name);
    }
}
