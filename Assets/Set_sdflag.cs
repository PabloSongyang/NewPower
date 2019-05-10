using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Set_sdflag : MonoBehaviour {

    [SerializeField]
    Text all;

    public void set_sdflag()
    {
        if (Static.Instance.GetValue("sdflag") == "0")
        {
            all.text = "金额必须是1000的倍数，第一次可以排单1000-5000元，每完成一轮，可增加2000元额度。每个账号最高排单20000元，排单每1000元消耗1个排单币";
        }
        else
        {
            all.text = "金额必须是1000的倍数 您当前的排单下限是" + Static.Instance.GetValue("sc_money")+ "，上限是20000元 排单每1000元消耗1个车位管理费";
        }
    }
}
