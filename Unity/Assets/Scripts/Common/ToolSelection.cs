using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolSelection : MonoBehaviour
{
    /* �I�𒆂̃c�[����ێ� �����l:0(Pen)
               Pen=0   Highrighter=1 
            Eraser=2 Constractions=3
    */
    public enum Toolmode
    {
        Pen,
        Highlighter,
        Eraser,
        Constractions
    }
    public Toolmode UsingTool = Toolmode.Pen;

    // �I�𒆂̐F�̕ێ�
    public enum ColorPicker
    {
        first,
        second,
        third
    }
    public ColorPicker CurColor = ColorPicker.first;

    // Start is called before the first frame update
    void Start()
    {

    }


    // �c�[�����I�����ꂽ�Ƃ��̏���
    public void ChangeTool ()
    {
        switch (UsingTool)
        {
            case Toolmode.Pen:
                break;

            case Toolmode.Highlighter:
                break;

            case Toolmode.Eraser:
                break;

            case Toolmode.Constractions:
                break;

        }
    }

    // �J���[�s�b�J�[�������ꂽ�Ƃ��̏���
    public void ChangeColorPicker
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
