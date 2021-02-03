using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class MVRPinput : MonoBehaviour
{
    [SerializeField]
    private Button LeftButton;

    private MVRPModel Model;

    public void InjectModel(MVRPModel model)
    {
        Model = model;
    }

    void Start()
    {
        LeftButton.OnClickAsObservable()
            .Subscribe(_ =>
            {
                Vector3 position = Model.CubePosition.Value;
                position.z += 3f;
                Model.CubePosition.Value = position;
            });
    }
}
