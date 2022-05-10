using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CellType { Empty, Mine, Count }
public class CellCon : MonoBehaviour
{
    [SerializeField]int _cellZize = 0;//セルのサイズ
    [SerializeField] GameObject _cover;
    CellType _celltype = CellType.Empty;
    GameManager _manager;
    int _index;
    bool _markState = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Initialize(GameManager manager,int index)
    {
        _manager = manager;
        _index = index;
    }
    public void CellCheck()//セルが地雷かどうか調べる
    {
        _cover.SetActive(false);
        switch(_celltype)
        {
            case CellType.Empty://安全なセルの場合
                //ゲームマネージャーに隣接タイルを掘ってもらう
                _manager.Kaiji(_index);
                break;
            case CellType.Mine://地雷セルの場合
                //ゲームマネージャーにゲームオーバー処理してもらう
                _manager.GameOver();
                break;
            case CellType.Count://地雷の隣の場合
                MineCount();
                break;
        }
    }
    void MineCount()//周囲の地雷数を表示
    {

    }
    void SetMark()//印をつける
    {
        if(_markState==false)
        {

        }
        else
        {

        }
    }
}
