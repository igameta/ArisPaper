using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace Drawing
{
    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(Collider2D))]

    public class InputSystem_Drawable : MonoBehaviour
    {
        //�y���ނ̐F
        public static Color PenColor = Color.black;
        public static Color HighColor = Color.yellow;
        //�ꎞ�I�Ȏ����@��ŕς���
        public static Color UsingColor = Color.black;

        // �y���ނ̑���
        public static double Pen_weidth = 1.0;
        public static double High_weidth = 2.5;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}