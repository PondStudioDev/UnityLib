using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_HPBar : UI_Base
{
    enum GameObjects
    {
        HPBar
    }

    Stat _stat;
    public override void Init()
    {
        Bind<GameObject>(typeof(GameObjects));
        _stat = transform.parent.GetComponent<Stat>();
    }
    
    private void Update()
    {
        Transform parent = transform.parent;
        transform.position = parent.position + (new Vector3(0, 1.2f, 0) * (parent.GetComponent<Collider>().bounds.size.y));
        transform.rotation = Camera.main.transform.rotation;

        float ratio = _stat.HP / (float)_stat.MaxHp;
        SetHpRatio(ratio);
    }

    public void SetHpRatio(float ratio)
    {
        GetObject((int)GameObjects.HPBar).GetComponent<Slider>().value = ratio;
    }
}
