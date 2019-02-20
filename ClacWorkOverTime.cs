using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClacWorkOverTime : MonoBehaviour
{
    /// <summary>
    /// 终点时间数列
    /// </summary>
    int[] finalTime = new int[] {2045,2046,2047,2046,2046,2047,2046,2045,2045,2045,2046,2105,2105,2102,2048,2048,2046,2047,2047};

    /// <summary>
    /// 总分钟
    /// </summary>
    int sum = 0;

    /// <summary>
    /// 单个小时数
    /// </summary>
    int hour = 0;

    /// <summary>
    /// 单个分钟数
    /// </summary>
    int minute = 0;

    /// <summary>
    /// 时间数列长度
    /// </summary>
    int aL;

    /// <summary>
    /// 最终小时数
    /// </summary>
    int finalHour;

    /// <summary>
    /// 最终分钟数
    /// </summary>
    int finalminute;

    /// <summary>
    /// 开始时间    分钟单位
    /// </summary>
    int beginTime;

    void Start()
    {
        beginTime = 17 * 60 + 45;
        aL = finalTime.Length;
        for (int i = 0; i < aL; i++)
        {
            hour = finalTime[i] / 100;
            minute = finalTime[i] % 100;
            sum += hour * 60 + minute - beginTime;

        }
        finalHour = sum / 60;
        finalminute = sum % 60;
        Debug.Log("加班天数：" + aL);
        Debug.Log("总分钟：" + sum);
        Debug.Log("最终小时数：" + finalHour);
        Debug.Log("最终分钟数：" + finalminute);
    }
}
