using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ֻ��� ������ �߻� Ŭ����
public abstract class Item 
{
    public string name;

    public abstract void Operate();

    public Item(string _name)
    {
        this.name = _name;
        Debug.Log("������ : " + name);
    }
}
