using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 복합 객체(Composite)
public class MineralBag : Item
{
    private List<Item> itemList = new List<Item>();

    public MineralBag(string name) : base(name)
    {
        // 해당 광물 가방 아이템 이름 세팅
    }

    public override void Operate()
    {
        OpenSlot();
    }

    // 가방을 여는 메소드
    private void OpenSlot()
    {

    }

    // 가방에 아이템을 넣을때 사용하는 메소드
    public void Add(Item item)
    {
        if(itemList.Contains(item)) 
        {
            Debug.Log("이미 동일한 아이템이 존재합니다.");
            return;
        }

        itemList.Add(item);
    }

    public void Remove(Item item) 
    { 
        if(!itemList.Contains(item)) 
        {
            Debug.Log("해당 아이템이 존재하지 않습니다.");
            return;
        }

        itemList.Remove(item);
    }
}
