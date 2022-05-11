using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;//これがないとIPointerClickHandlerは動かないからusingに追加しよう
//自分で右クリックに反応するボタンを作成する
public class FlagButtonController : MonoBehaviour, IPointerClickHandler//IPointerClickHandler（インターフェース）を継承する
{
    public void OnPointerClick(PointerEventData eventData)//IPointerClickHandler（インターフェース）
    {
        switch (eventData.button)
        {
            case PointerEventData.InputButton.Left:
                //左クリックの処理
                break;
            case PointerEventData.InputButton.Right:
                //右クリックの処理
                break;
            case PointerEventData.InputButton.Middle:
                //（ホイールクリックの処理、は）無いです
                break;
        }
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
