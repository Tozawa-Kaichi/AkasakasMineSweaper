using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CellType { Empty, Mine, Count }
public class CellCon : MonoBehaviour
{
    [SerializeField]int _cellZize = 0;
    CellType _celltype = CellType.Empty;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CellCheck()//セルが地雷かどうか調べる
    {
        //安全なセルの場合

        //地雷セルの場合

        //地雷の隣の場合
    }
    void MineCount()//周囲の地雷数を表示
    {

    }
    void SetMark()//印をつける
    {

    }
}
