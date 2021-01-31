using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{

    public float hunger;
    public float thirst;
    public string personName;
    private Transform trans;
    private Rigidbody2D body;

    private float movingVelocity;

    private float rotationVelocity;

    public List<Sprite> sprites;

    public AudioClip sinkSound;

    private SpriteRenderer hungerSpriteRect;

    private SpriteRenderer thristSpriteRect;

    private Color green = new Color(0, 1, 0, 1);
    private Color yellow = new Color(1, 1, 0, 1);
    private Color red = new Color(1, 0, 0, 1);

    public GUIStyle style;

    bool dying = false;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();


        hungerSpriteRect = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
        thristSpriteRect = gameObject.transform.GetChild(2).GetComponent<SpriteRenderer>();

        personName = GameManagerScript.Instance.getName();

        hunger = Random.Range(0f, 40f);
        thirst = Random.Range(0f, 20f);

        
        var forceDirection = new Vector2(Random.Range(-360, 360), Random.Range(-360, 360));

        movingVelocity = Random.Range(50.0f, 1000f);
        rotationVelocity = Random.Range(-3000.0f, 3000f);

        body.AddForce(forceDirection * movingVelocity);

        GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Count - 1)];

    }

    void Update() {
        if (rotationVelocity > 0) {
            transform.Rotate(Vector3.forward * rotationVelocity * Time.deltaTime);
            //transform.eulerAngles = Vector3.forward * 45 * rotationVelocity;
            rotationVelocity -= 5f;
        }


        if (hunger < 100) {
            hunger = Mathf.Min(hunger + 4f * Time.deltaTime, 100);
        }

        if (thirst < 100) {
            thirst = Mathf.Min(thirst + 8f * Time.deltaTime, 100);
        }

        if (thirst >= 100 || hunger >= 100) {
            dying = true;
        }

        if (dying) {
            var c = GetComponent<SpriteRenderer>().color;
            GetComponent<SpriteRenderer>().color = Color.Lerp(c, new Color(c.r, c.g, c.b, 0f), 1 * Time.deltaTime);
        }

        if (GetComponent<SpriteRenderer>().color.a <= 0.01) {
            die();
        }

        setHungerColor();
        setThirstColor();

    }

    void setHungerColor() {
        Color color;
        if (hunger > 0 && hunger < 66) {
            color = Color.Lerp(green, yellow, hunger / 66f);
        } else {
            color = Color.Lerp(yellow, red, (hunger - 66) / 33f);
        }

        hungerSpriteRect.color = color;

    }

    void setThirstColor() {
        Color color;
        if (thirst > 0 && thirst < 66) {
            color = Color.Lerp(green, yellow, thirst / 66f);
        } else {
            color = Color.Lerp(yellow, red, (thirst - 66) / 33f);
        }

        thristSpriteRect.color = color;

    }

    void die()
    {
        GameManagerScript.Instance.lifeBoatDeath(personName);
        AudioSource.PlayClipAtPoint(sinkSound, transform.position, 100f);
        Destroy(gameObject);
    }


    void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent(personName));
        GUI.Label(new Rect(position.x, Screen.height - position.y, textSize.x, textSize.y), personName, style);
    }
}
