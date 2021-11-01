using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FishSizeMovement:MonoBehaviour {
public GameObject fish;
private float _currentScale = InitScale;
private const float TargetScale =5.0f;
private const float InitScale = 5.0f;
private const int FramesCount = 20;
private const float AnimationTimeSeconds = 0.5f;
private float _deltaTime = AnimationTimeSeconds / FramesCount;
private float _dx = (TargetScale - InitScale) / FramesCount;
private bool _upScale = true;
 public IEnumerator Breathe() {
    {
        while (true)
        {
            while (_upScale)
            {
                _currentScale += _dx;
                if (_currentScale > TargetScale)
                {
                    _upScale = false;
                    _currentScale = TargetScale;
                }
                fish.transform.localScale = Vector3.one * _currentScale;
                yield return new WaitForSeconds(_deltaTime);
            }

            while (!_upScale)
            {
                _currentScale -= _dx;
                if (_currentScale < InitScale)
                {
                    _upScale = true;
                    _currentScale = InitScale;
                }
                fish.transform.localScale = Vector3.one * _currentScale;
                yield return new WaitForSeconds(_deltaTime);
            }
        }
    }
      void Start()
    {
        StartCoroutine(Breathe());
    }
}
}