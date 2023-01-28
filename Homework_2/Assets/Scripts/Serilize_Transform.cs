using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Serilize_Transform
{
    public float positionX,positionY, positionZ;
    public float rotaisonX, rotaisonY, rotaisonZ;
    public float scaleX, scaleY, scaleZ;


    public static explicit operator Serilize_Transform(Transform fromTransform)
    {
        return new Serilize_Transform
        {
            positionX = fromTransform.position.x,
            positionY = fromTransform.position.y,
            positionZ = fromTransform.position.z,

            rotaisonX = fromTransform.rotation.x,
            rotaisonY = fromTransform.rotation.y,
            rotaisonZ = fromTransform.rotation.z,

            scaleX = fromTransform.localScale.x,
            scaleY = fromTransform.localScale.y,
            scaleZ = fromTransform.localScale.z,

        };
    }
}
