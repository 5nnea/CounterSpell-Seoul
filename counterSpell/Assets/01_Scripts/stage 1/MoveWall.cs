using UnityEngine;
using DG.Tweening;

public class MoveWall : MonoBehaviour
{
    public void WallMove(){
        transform.DOMoveY(-2,1f).SetEase(Ease.InBounce);
    }
}
