public static void RightArmGun()//UND
{
    if (ControllerInputPoller.instance.rightGrab)
    {
        Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position, -GorillaLocomotion.Player.Instance.rightControllerTransform.up, out var hitInfo);
        if (change17 == 1)
        {
            pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            pointer.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
            pointer.transform.position = hitInfo.point;
        }
        if (change17 == 2 | change17 == 3)
        {
            pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            if (change17 == 2)
            {
                UnityEngine.Object.Destroy(pointer.GetComponent<Renderer>());
            }
            pointer.transform.position = hitInfo.point;
            GameObject gameObject2 = new GameObject("Line");
            Line = gameObject2.AddComponent<LineRenderer>();
            Line.material.shader = Shader.Find("GUI/Text Shader");
            Line.startWidth = 0.025f;
            Line.endWidth = 0.025f;
            if (change8 == 1)
            {
                Line.startColor = Color.blue;
                Line.endColor = Color.blue;
            }
            if (change8 == 2)
            {
                Line.startColor = Color.red;
                Line.endColor = Color.red;
            }
            if (change8 == 3)
            {
                Line.startColor = Color.white;
                Line.endColor = Color.white;
            }
            if (change8 == 4)
            {
                Line.startColor = Color.green;
                Line.endColor = Color.green;
            }
            if (change8 == 5)
            {
                Line.startColor = Color.magenta;
                Line.endColor = Color.magenta;
            }
            if (change8 == 6)
            {
                Line.startColor = Color.cyan;
                Line.endColor = Color.cyan;
            }
            if (change8 == 7)
            {
                Line.startColor = Color.yellow;
                Line.endColor = Color.yellow;
            }
            if (change8 == 8)
            {
                Line.startColor = Color.black;
                Line.endColor = Color.black;
            }
            if (change8 == 9)
            {
                Line.startColor = Color.grey;
                Line.endColor = Color.grey;
            }
            if (change8 == 10)
            {
                GradientColorKey[] array = new GradientColorKey[7];
                array[0].color = Color.red;
                array[0].time = 0f;
                array[1].color = Color.yellow;
                array[1].time = 0.2f;
                array[2].color = Color.green;
                array[2].time = 0.3f;
                array[3].color = Color.cyan;
                array[3].time = 0.5f;
                array[4].color = Color.blue;
                array[4].time = 0.6f;
                array[5].color = Color.magenta;
                array[5].time = 0.8f;
                array[6].color = Color.red;
                array[6].time = 1f;
                Gradient gradient = new Gradient();
                gradient.colorKeys = array;
                float num = Mathf.PingPong(Time.time / 2f, 1f);
                Color color = gradient.Evaluate(num);
                Line.startColor = color;
                Line.endColor = color;
            }
            Line.positionCount = 2;
            Line.useWorldSpace = true;
            Line.SetPosition(0, GorillaLocomotion.Player.Instance.rightControllerTransform.position);
            Line.SetPosition(1, pointer.transform.position);
            UnityEngine.Object.Destroy(gameObject2, Time.deltaTime);
        }
        if (change8 == 1)
        {
            pointer.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (change8 == 2)
        {
            pointer.GetComponent<Renderer>().material.color = Color.red;
        }
        if (change8 == 3)
        {
            pointer.GetComponent<Renderer>().material.color = Color.white;
        }
        if (change8 == 4)
        {
            pointer.GetComponent<Renderer>().material.color = Color.green;
        }
        if (change8 == 5)
        {
            pointer.GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (change8 == 6)
        {
            pointer.GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (change8 == 7)
        {
            pointer.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (change8 == 8)
        {
            pointer.GetComponent<Renderer>().material.color = Color.black;
        }
        if (change8 == 9)
        {
            pointer.GetComponent<Renderer>().material.color = Color.grey;
        }
        if (change8 == 10)
        {
            GradientColorKey[] array = new GradientColorKey[7];
            array[0].color = Color.red;
            array[0].time = 0f;
            array[1].color = Color.yellow;
            array[1].time = 0.2f;
            array[2].color = Color.green;
            array[2].time = 0.3f;
            array[3].color = Color.cyan;
            array[3].time = 0.5f;
            array[4].color = Color.blue;
            array[4].time = 0.6f;
            array[5].color = Color.magenta;
            array[5].time = 0.8f;
            array[6].color = Color.red;
            array[6].time = 1f;
            Gradient gradient = new Gradient();
            gradient.colorKeys = array;
            float num = Mathf.PingPong(Time.time / 2f, 1f);
            Color color = gradient.Evaluate(num);
            pointer.GetComponent<Renderer>().material.color = color;
        }
        UnityEngine.Object.Destroy(pointer.GetComponent<BoxCollider>());
        UnityEngine.Object.Destroy(pointer.GetComponent<Rigidbody>());
        UnityEngine.Object.Destroy(pointer.GetComponent<Collider>());
        if (ControllerInputPoller.instance.rightControllerIndexFloat == 1f)
        {
            GorillaLocomotion.Player.Instance.rightControllerTransform.position = hitInfo.point;
        }
    }
    if (pointer != null)
    {
        UnityEngine.Object.Destroy(pointer, Time.deltaTime);
    }
}

public static LineRenderer Line;

public static int change17 = 1;

public static int change8 = 1;

public static GameObject pointer;
