using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;//これがないとIPointerClickHandlerは動かないからusingに追加しよう
//自分で右クリックに反応するボタンを作成する
public class FlagButtonController : MonoBehaviour, IPointerClickHandler  //これをモノビヘィビァーの後ろに追加する
{
    public void OnPointerClick(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
