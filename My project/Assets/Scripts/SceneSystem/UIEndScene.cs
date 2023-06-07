using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEndScene : MonoBehaviour
{
    protected SceneChanger SceneChanger => SceneChanger.Instance;           //�̱��� �ҷ�����
    public Button gameButton;                           //������ ��ư ����

    // Start is called before the first frame update
    void Start()
    {
        gameButton.onClick.AddListener(OnGameButtonClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGameButtonClick()
    {
        SceneChanger.LoadLobbyScene();
    }
}