using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;
    
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    
    void GenerateData()
    {
        talkData.Add(1000, new string[] { "�ȳ�:1", "�� ���� ó�� �Ա���?:0" });
        talkData.Add(2000, new string[] { "����.:0", "�� ȣ���� ���� �Ƹ�����??:1", "��� �� ȣ������ ������ ����� ������ �ִٰ� ��:1" });
        talkData.Add(3000, new string[] { "����� �������ڴ�." });
        talkData.Add(4000, new string[] { "������ ����ߴ� ������ �ִ� å���̴�." });

        //Quest Talk
        talkData.Add(1000 + 10, new string[] {"� ��.:0",
                                              "�� ������ ���� ������ �ִٴµ�:1",
                                                 "������ ȣ�� �ʿ� �絵�� �˷��ٲ���.:2"});
        talkData.Add(2000 + 11, new string[] { "����..:1",
                                       "�� ȣ���� ������ ������ �°ž�?:0",
                                       "�׷� �� �� �ϳ� ���ָ� �����ٵ�...:1",
                                       "�� �� ��ó�� ������ ���� �� �ֿ������� ��:0"});
        talkData.Add(1000 + 20, new string[] {"�絵�� ����?:1",
                                      "���� �긮�� �ٴϸ� ������!:3",
                                      "���߿� �絵���� �� ���� �ؾ߰ھ�!!:3"});
        talkData.Add(2000 + 20, new string[] { "ã���� �� �� ������ ��.:1" });
        talkData.Add(2000 + 21, new string[] { "��, ã���༭ ������..:2" });
        talkData.Add(5000 + 20, new string[] { "��ó���� ������ ã�Ҵ�." });


        portraitData.Add(1000+0, portraitArr[0]);
        portraitData.Add(1000+1, portraitArr[1]);
        portraitData.Add(1000+2, portraitArr[2]);
        portraitData.Add(1000+3, portraitArr[3]);
        portraitData.Add(2000+0, portraitArr[4]);
        portraitData.Add(2000+1, portraitArr[5]);
        portraitData.Add(2000+2, portraitArr[6]);
        portraitData.Add(2000+3, portraitArr[7]);
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (!talkData.ContainsKey(id))
        {
            if (!talkData.ContainsKey(id - id % 10))
                return GetTalk(id - id % 100, talkIndex);
            else
                return GetTalk(id - id % 100, talkIndex);
        }
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {
        return portraitData[id + portraitIndex];
    }
}