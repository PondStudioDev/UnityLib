using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UI_Inven : UI_Scene
{
    enum GameObjects
    {
        GridPannel
    }
    void Start()
    {
        Init();
    }

    public override void Init()
    {
        base.Init();

        Bind<GameObject>(typeof(GameObjects));

        GameObject gridPanel = Get<GameObject>((int)GameObjects.GridPannel);
        foreach (Transform child in gridPanel.transform)
            Managers.Resource.Destroy(child.gameObject);

        for (int i = 0; i < 8; i++)
        {
            GameObject inven_item = Managers.UI.MakeSubItem<UI_Inven_Item>(gridPanel.transform).gameObject;
            inven_item.GetComponent<UI_Inven_Item>().SetInfo($"구원의 이기 : {i}");
                //UI_Inven_Item.SetInfo;
        }
    }
}
