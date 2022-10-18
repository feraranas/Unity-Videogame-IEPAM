using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using TMPro;
using Newtonsoft.Json.Linq;
using System;

[System.Serializable]
public class Preguntas
{
    public string pregunta;
    public string respuestaCorrecta;
    public string respuestaIncorrecta1;
    public string respuestaIncorrecta2;
    public string respuestaIncorrecta3;

    public string getPregunta()
    {
        return pregunta;
    }

}

public class BasketballController : MonoBehaviour
{

    public float MoveSpeed = 10;
    public Transform Ball;
    public Transform Arms;
    public Transform PosOverHead;
    public Transform PosDribble;

    public Transform Target_A;
    public Transform Target_B;
    public Transform Target_C;
    public Transform Target_D;

    public List<Preguntas> PreguntasTrivia;

    public string pregunta;
    public string respuestaCorrecta;
    public string respuestaIncorrecta1;
    public string respuestaIncorrecta2;
    public string respuestaIncorrecta3;

    public TextMeshProUGUI pregunta_C;
    public TextMeshProUGUI respuesta_A;
    public TextMeshProUGUI respuesta_B;
    public TextMeshProUGUI respuesta_C;
    public TextMeshProUGUI respuesta_D;
    public TextMeshProUGUI resultado;

    private bool IsBallInHands = true;
    private bool IsBallFlying = false;
    private float T = 0;

    private float dist_A = 0;
    private float dist_B = 0;
    private float dist_C = 0;
    private float dist_D = 0;
    private Vector3 Target;

    private float min_dist_target = 0;

    private string resp;
    private Vector3 pos_resp;

    void Start()
    {

        if (PreguntasTrivia.Count != 0)
        {
            int preguntaRand = UnityEngine.Random.Range(0, PreguntasTrivia.Count);
            pregunta = PreguntasTrivia[preguntaRand].pregunta;
            pregunta = PreguntasTrivia[preguntaRand].getPregunta();
            respuestaCorrecta = PreguntasTrivia[preguntaRand].respuestaCorrecta;
            respuestaIncorrecta1 = PreguntasTrivia[preguntaRand].respuestaIncorrecta1;
            respuestaIncorrecta2 = PreguntasTrivia[preguntaRand].respuestaIncorrecta2;
            respuestaIncorrecta3 = PreguntasTrivia[preguntaRand].respuestaIncorrecta3;
        }

        string[] respuestas = {"","","",""};
        string[] respuestasOrd = { respuestaCorrecta, respuestaIncorrecta1, respuestaIncorrecta2, respuestaIncorrecta3 };

        for (int i = 0; i <= 2; i++)
        {
            int randomNumber = UnityEngine.Random.Range(0, 3);
            while (respuestas[randomNumber] != "")
            {
                randomNumber = UnityEngine.Random.Range(0, 3);
            }
            respuestas[randomNumber] = respuestasOrd[i];
            if (i == 0)
            {
                if (randomNumber == 0)
                {
                    resp = "A";
                }
                else if (randomNumber == 1)
                {
                    resp = "B";
                }
                else if (randomNumber == 2)
                {
                    resp = "C";
                }
                else if (randomNumber == 3)
                {
                    resp = "D";
                }
            }
        }

        int pos = Array.IndexOf(respuestas, "");
        respuestas[pos] = respuestasOrd[3];

        pregunta_C.text = pregunta;
        respuesta_A.text = "A) " + respuestas[0];
        respuesta_B.text = "B) " + respuestas[1];
        respuesta_C.text = "C) " + respuestas[2];
        respuesta_D.text = "D) " + respuestas[3];


        if (resp == "A")
        {
            pos_resp = Target_A.position;
        }
        else if (resp == "B")
        {
            pos_resp = Target_B.position;
        }
        else if (resp == "C")
        {
            pos_resp = Target_C.position;
        }
        else if (resp == "D")
        {
            pos_resp = Target_D.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // walking
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        transform.position += direction * MoveSpeed * Time.deltaTime;
        transform.LookAt(transform.position + direction);
        // ball in hands
        if (IsBallInHands)
        {
            // hold over head
            //if (Input.GetKey(KeyCode.Space))
            if (Input.GetKey(KeyCode.Space))
            {
                Ball.position = PosOverHead.position;
                Arms.localEulerAngles = Vector3.right * 180;

                // look towards the target

                dist_A = Vector3.Distance(Target_A.position, transform.position);
                dist_B = Vector3.Distance(Target_B.position, transform.position);
                dist_C = Vector3.Distance(Target_C.position, transform.position);
                dist_D = Vector3.Distance(Target_D.position, transform.position);

                min_dist_target = Mathf.Min(dist_A, dist_B, dist_C, dist_D);

                if (dist_A == min_dist_target)
                {
                    transform.LookAt(Target_A.position);
                    Target = Target_A.position;

                }
                else if (dist_B == min_dist_target)
                {
                    transform.LookAt(Target_B.position);
                    Target = Target_B.position;
                }
                else if (dist_C == min_dist_target)
                {
                    transform.LookAt(Target_C.position);
                    Target = Target_C.position;
                }
                else
                {
                    transform.LookAt(Target_D.position);
                    Target = Target_D.position;
                }

            }

            // dribbling
            else
            {
                Ball.position = PosDribble.position + Vector3.up * Mathf.Abs(Mathf.Sin(Time.time * 5));
                Arms.localEulerAngles = Vector3.right * 0;
            }

            // throw ball
            if (Input.GetKeyUp(KeyCode.Space))
            {
                IsBallInHands = false;
                IsBallFlying = true;
                T = 0;
            }

        }

        // ball in the air
        if (IsBallFlying)
        {
            T += Time.deltaTime;
            float duration = 0.5f;
            float t01 = T / duration;

            Vector3 A = PosOverHead.position;
            Vector3 B = Target;
            Vector3 pos = Vector3.Lerp(A, B, t01);

            // move in arc
            Vector3 arc = Vector3.up * 5 * Mathf.Sin(t01 * 3.14f);

            Ball.position = pos + arc;

            // moment when the ball arrives at target
            if (t01 >= 1)
            {
                IsBallFlying = false;
                Ball.GetComponent<Rigidbody>().isKinematic = false;


                if (Vector3.Distance(pos_resp, Ball.position) < 1)
                {
                    resultado.text = "!Correcto!";
                }
                else
                {
                    resultado.text = "¡Incorrecto! Vuelve a intentar";
                }
            }

        }


    }

    private void OnTriggerEnter(Collider other)
    {

        if(!IsBallInHands && !IsBallFlying)
        {
            IsBallInHands = true;
            Ball.GetComponent<Rigidbody>().isKinematic = true;
            resultado.text = "";
        }
    }
}
