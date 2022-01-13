using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Block
{

    List<List<string[][]>> AllBlock = new List<List<string[][]>>();

    void DataInit()
    {
        for (int BT = 0; BT < (int)BLOCKTYPE.BT_MAX; ++BT)
        {
            AllBlock.Add(new List<string[][]>());

            for (int BD = 0; BD < (int)BLOCKDIR.BD_MAX; ++BD)
            {
                AllBlock[BT].Add(null);
            }
        }


        #region I
        //막대의 T
        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_T] = new string[][]
         {
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "□", "□", "□" },
         };


        //막대의 R
        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_R] = new string[][]
       {
            new string[]{ "■", "■", "■", "■" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };


        //막대의 B
        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "□", "□", "□" },
        };

        //막대의 L
        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_L] = new string[][]
       {
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "□", "□", "□" },
        };

        #endregion

        #region T
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_T] = new string[][]
       {
            new string[]{ "□", "■", "□", "□" },
            new string[]{ "■", "■", "■", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };


        //막대의 R
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[]{ "□", "■", "□", "□" },
            new string[]{ "□", "■", "■", "□" },
            new string[]{ "□", "■", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };


        //막대의 R
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_B] = new string[][]
       {
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "■", "■", "■", "□" },
            new string[]{ "□", "■", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };

        //막대의 L
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[]{ "□", "■", "□", "□" },
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "■", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };
        #endregion

        #region L
        //L의 T
        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_T] = new string[][]
        {
            new string[]{ "□", "□", "■", "□" },
            new string[]{ "■", "■", "■", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };


        //L의 R
        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };


        //L의 B
        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[]{ "■", "■", "■", "□" },
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };

        //L의 L
        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "■", "□", "□" },
            new string[]{ "□", "■", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };
        #endregion

        #region J
        //L의 T
        AllBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_T] = new string[][]
       {
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "■", "■", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };


        //L의 R
        AllBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };


        //L의 B
        AllBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[]{ "■", "■", "■", "□" },
            new string[]{ "□", "□", "■", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };

        //L의 L
        AllBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[]{ "□", "■", "□", "□" },
            new string[]{ "□", "■", "□", "□" },
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };
        #endregion

        #region O
        //L의 T
        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_T] = new string[][]
        {
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };


        //L의 R
        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };


        //L의 B
        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        //L의 L
        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_L] = new string[][]
        {
             new string[]{ "■", "■", "□", "□" },
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };
        #endregion

        #region S
        //L의 T
        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_T] = new string[][]
       {
            new string[]{ "□", "■", "■", "□" },
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };


        //L의 R
        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "■", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };


        //L의 B
        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[]{ "□", "■", "■", "□" },
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };

        //L의 L
        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "■", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };
        #endregion

        #region Z
        //L의 T
        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_T] = new string[][]
       {
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "■", "■", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };


        //L의 R
        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[]{ "□", "■", "□", "□" },
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "■", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };


        //L의 B
        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "■", "■", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };

        //L의 L
        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[]{ "■", "■", "□", "□" },
            new string[]{ "□", "■", "■", "□" },
            new string[]{ "□", "□", "□", "□" },
            new string[]{ "□", "□", "□", "□" },
        };
        #endregion


    }
}
