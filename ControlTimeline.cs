using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using Cinemachine;
using DG.Tweening;

public class RoleInformation {
    public int roleID;
    public string roleName;
    public int[] roleTrackID;
}

public class ControlTimeline : MonoBehaviour {
    public PlayableDirector playableDir;
    public bool isPlayback=false;
    public TimelineAsset asset;
    public List<TrackAsset>  trackAssets=new List<TrackAsset>();
    [Header("回放速度"),SerializeField,Range(0.1f,10)]
    private float playbackTime=0.1f;
    RoleInformation roleInformation, roleInformation2;
    private void OnEnable()
    {
        roleInformation = new RoleInformation
        {
            roleTrackID = new int[3] { 0,2,4 }
        };
        roleInformation2 = new RoleInformation
        {
            roleTrackID = new int[2] { 1,3 }
        };
    }
    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChooseRole(roleInformation);
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            ChooseRole(roleInformation2);
        }
     
    }

    [ContextMenu("获取轨道信息")]
    public void GetTrackAssets() {
        trackAssets = new List<TrackAsset>();
        foreach (var item in asset.outputs)
        {
            if (!trackAssets.Contains(item.sourceObject as TrackAsset))
            {
                trackAssets.Add(item.sourceObject as TrackAsset);
            }
          
        }
      
    }

    [ContextMenu("设置全体不静音")]
    public void SetAllDontMute() {
        for (int i = 0; i < trackAssets.Count; i++)
        {
            trackAssets[i].muted = false;
        }
        
    }

    [ContextMenu("设置全体静音")]
    public void SetAllMute()
    {
        for (int i = 0; i < trackAssets.Count; i++)
        {
            trackAssets[i].muted = true;
        }

    }

    /// <summary>
    /// 选择角色
    /// </summary>
    /// <param name="_roleTrackID"></param>
    public void ChooseRole(RoleInformation _roleInformation) {
        isPlayback = false;
        ResetTimeline();
        StartCoroutine(SetMuteState(_roleInformation.roleTrackID));
    }

    IEnumerator SetMuteState(int[] _roleTrackID) {
        yield return new WaitUntil(GetPlaybackValue);
        GetTrackAssets();
        for (int i = 0; i < trackAssets.Count; i++)
        {
            for (int j = 0; j < _roleTrackID.Length; j++)
            {
                if (_roleTrackID[j] == i)
                {
                    trackAssets[i].muted = false;
                    break;
                }
                else
                {
                    trackAssets[i].muted = true;
                }
            }
           
        }
        playableDir.Stop();
        playableDir.Play();
    }

    public void ResetTimeline() {
        if (playableDir.time>0)
        {
            DOTween.To(() => playableDir.time, x => playableDir.time = x, 0, playbackTime).OnComplete(PlaybackOver);
        }
        else
        {
            PlaybackOver();
        }
    }

    public void PlaybackOver() {
        isPlayback = true;
    }

    public bool GetPlaybackValue() {
        return isPlayback;
    }
}
