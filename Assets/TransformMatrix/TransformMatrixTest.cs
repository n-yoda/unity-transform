using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class TransformMatrixTest : MonoBehaviour
{
    [CompactMatrix4x4(true)]
    public Matrix4x4 expected;
    [CompactMatrix4x4(true)]
    public Matrix4x4 test;
    [CompactMatrix4x4]
    public Matrix4x4 error;

    void Update()
    {
        expected = transform.localToWorldMatrix;
        test = TransformMatrix.LocalToWorld(transform);
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                error[i, j] = Mathf.Abs(test[i, j] - expected[i, j]);
            }
        }
    }
}
