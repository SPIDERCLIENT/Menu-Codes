public static void DisableSkeletonEsp()//UND
{
    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
    {
        if (vrrig != null && !vrrig.isOfflineVRRig)
        {
            UnityEngine.Object.Destroy(vrrig.gameObject.GetComponent<Codes.RGBSkeletonESPClass>());
        }
    }
}

public class RGBSkeletonESPClass : MonoBehaviour
{
    private void Start()
    {
        this.lineRenderer = base.gameObject.AddComponent<LineRenderer>();
        this.lineRenderer.material = new Material(Shader.Find("GUI/Text Shader"));
        this.lineRenderer.startWidth = this.lineWidth;
        this.lineRenderer.endWidth = this.lineWidth;
    }

    private void Update()
    {
        this.DrawSkeleton();
    }

    private void OnDestroy()
    {
        this.ClearLineObjects();
    }

    public void DrawSkeleton()
    {
        this.ClearLineObjects();
        VRRig component = base.GetComponent<VRRig>();
        if (component == null)
        {
            UnityEngine.Debug.LogWarning("niga2");
            return;
        }
        Color animatedColor = this.GetAnimatedColor();
        this.DrawLine(component.headMesh.transform.position - new Vector3(0f, 0.35f, 0f), component.headMesh.transform.position, animatedColor);
        this.DrawLine(component.headMesh.transform.position - new Vector3(0f, 0.05f, 0f), component.headMesh.transform.position + component.headMesh.transform.up * 0.2f, animatedColor);
        this.DrawLine(component.headMesh.transform.position - new Vector3(0f, 0.05f, 0f), component.headMesh.transform.position + component.transform.right * -0.15f, animatedColor);
        this.DrawLine(component.headMesh.transform.position - new Vector3(0f, 0.05f, 0f), component.headMesh.transform.position + component.transform.right * 0.15f, animatedColor);
        this.DrawLine(component.headMesh.transform.position + component.transform.right * -0.15f, component.myBodyDockPositions.leftArmTransform.position, animatedColor);
        this.DrawLine(component.headMesh.transform.position + component.transform.right * 0.15f, component.myBodyDockPositions.rightArmTransform.position, animatedColor);
        this.DrawLine(component.myBodyDockPositions.leftArmTransform.position, component.leftHandTransform.position, animatedColor);
        this.DrawLine(component.myBodyDockPositions.rightArmTransform.position, component.rightHandTransform.position, animatedColor);
        this.DrawLine(component.rightHandTransform.position, component.rightThumb.fingerBone1.position, animatedColor);
        this.DrawLine(component.rightThumb.fingerBone1.position, component.rightThumb.fingerBone2.position, animatedColor);
        this.DrawLine(component.rightHandTransform.position, component.rightIndex.fingerBone1.position, animatedColor);
        this.DrawLine(component.rightIndex.fingerBone1.position, component.rightIndex.fingerBone2.position, animatedColor);
        this.DrawLine(component.rightIndex.fingerBone2.position, component.rightIndex.fingerBone3.position, animatedColor);
        this.DrawLine(component.rightHandTransform.position, component.rightMiddle.fingerBone1.position, animatedColor);
        this.DrawLine(component.rightMiddle.fingerBone1.position, component.rightMiddle.fingerBone2.position, animatedColor);
        this.DrawLine(component.rightMiddle.fingerBone2.position, component.rightMiddle.fingerBone3.position, animatedColor);
        this.DrawLine(component.leftHandTransform.position, component.leftThumb.fingerBone1.position, animatedColor);
        this.DrawLine(component.leftThumb.fingerBone1.position, component.leftThumb.fingerBone2.position, animatedColor);
        this.DrawLine(component.leftHandTransform.position, component.leftIndex.fingerBone1.position, animatedColor);
        this.DrawLine(component.leftIndex.fingerBone1.position, component.leftIndex.fingerBone2.position, animatedColor);
        this.DrawLine(component.leftIndex.fingerBone2.position, component.leftIndex.fingerBone3.position, animatedColor);
        this.DrawLine(component.leftHandTransform.position, component.leftMiddle.fingerBone1.position, animatedColor);
        this.DrawLine(component.leftMiddle.fingerBone1.position, component.leftMiddle.fingerBone2.position, animatedColor);
        this.DrawLine(component.leftMiddle.fingerBone2.position, component.leftMiddle.fingerBone3.position, animatedColor);
    }

    private Color GetAnimatedColor()
    {
        float time = Time.time;
        float num = Mathf.Sin(time * 2f) * 0.5f + 0.5f;
        float num2 = Mathf.Sin(time * 1.5f) * 0.5f + 0.5f;
        float num3 = Mathf.Sin(time * 2.5f) * 0.5f + 0.5f;
        return new Color(num, num2, num3);
    }

    private void ClearLineObjects()
    {
        foreach (GameObject gameObject in this.lineObjects)
        {
            UnityEngine.Object.Destroy(gameObject);
        }
        this.lineObjects.Clear();
    }

    private GameObject CreateLineObject()
    {
        GameObject gameObject = new GameObject("LineObject");
        gameObject.transform.SetParent(base.transform);
        this.lineObjects.Add(gameObject);
        return gameObject;
    }

    private void DrawLine(Vector3 startPos, Vector3 endPos, Color color)
    {
        LineRenderer lineRenderer = this.CreateLineObject().AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("GUI/Text Shader"));
        lineRenderer.startColor = color;
        lineRenderer.endColor = color;
        lineRenderer.startWidth = this.lineWidth;
        lineRenderer.endWidth = this.lineWidth;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPositions(new Vector3[]
        {
            startPos,
            endPos
        });
    }

    public Color lineColor = Color.white;
    public float lineWidth = 0.02f;
    private LineRenderer lineRenderer;
    private List<GameObject> lineObjects = new List<GameObject>();

}
