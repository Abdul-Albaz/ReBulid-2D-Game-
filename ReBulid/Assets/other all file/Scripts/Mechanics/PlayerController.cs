using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Gameplay;
using static Platformer.Core.Simulation;
using Platformer.Model;
using Platformer.Core;

namespace Platformer.Mechanics
{
    /// <summary>
    /// This is the main class used to implement control of the player.
    /// It is a superset of the AnimationController class, but is inlined to allow for any kind of customisation.
    /// </summary>
    public class PlayerController : KinematicObject
    {
        public AudioClip jumpAudio;
        public AudioClip respawnAudio;
        public AudioClip ouchAudio;
        private Vector2 DiractionStart;
        public GameObject Cvar;

       

        /// <summary>
        /// Max horizontal speed of the player.
        /// </summary>
        public float maxSpeed = 7;
        /// <summary>
        /// Initial jump velocity at the start of a jump.
        /// </summary>
        public float jumpTakeOffSpeed = 7;

        public JumpState jumpState = JumpState.Grounded;
        private bool stopJump;
        /*internal new*/ public Collider2D collider2d;
        /*internal new*/ public AudioSource audioSource;
        public Health health;
        public bool controlEnabled = true;

        bool jump;
        Vector2 move;
        SpriteRenderer spriteRenderer;
        internal Animator animator;
        readonly PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public Bounds Bounds => collider2d.bounds;

        void Awake()
        {
            health = GetComponent<Health>();
            audioSource = GetComponent<AudioSource>();
            collider2d = GetComponent<Collider2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
            animator = GetComponent<Animator>();
           

        }

        protected override void Update()
        {

            


           /* if (this.transform.position.y <= -3)
            {
               this.transform.position = new Vector3 (-12.12f, 0.48f, -2.96f);
                Cvar.transform.position = new Vector3(-5.645943f, 2.668464f, -12.96f);
                animator.SetBool("deth", true);
                StartCoroutine("dethloop");
                FindObjectOfType<AudioManger>().Play("hurt");

            }

            if (this.transform.position.y <= -2)
            {
                
                animator.SetBool("deth", true);
                StartCoroutine("dethloop");

            }*/




            if (controlEnabled)
            {
                
                move.x = Input.GetAxis("Horizontal");
                if (jumpState == JumpState.Grounded && Input.GetButtonDown("Jump"))
                    jumpState = JumpState.PrepareToJump;
                else if (Input.GetButtonUp("Jump"))
                {
                    stopJump = true;
                    Schedule<PlayerStopJump>().player = this;
                }
            }
            else
            {
                move.x = 0;
               
            }
            UpdateJumpState();
            base.Update();

           
        }

        IEnumerator dethloop()
        {

            yield return new WaitForSeconds(0.2f);
            animator.SetBool("deth", false);
            animator.SetBool("power", false);
        }
        void UpdateJumpState()
        {
            jump = false;
            switch (jumpState)
            {
                case JumpState.PrepareToJump:
                    jumpState = JumpState.Jumping;
                    jump = true;
                    stopJump = false;
                    break;
                case JumpState.Jumping:
                    if (!IsGrounded)
                    {
                        Schedule<PlayerJumped>().player = this;
                        jumpState = JumpState.InFlight;
                    }
                    break;
                case JumpState.InFlight:
                    if (IsGrounded)
                    {
                        Schedule<PlayerLanded>().player = this;
                        jumpState = JumpState.Landed;
                    }
                    break;
                case JumpState.Landed:
                    jumpState = JumpState.Grounded;
                    break;
            }
        }

        protected override void ComputeVelocity()
        {
            if (jump && IsGrounded)
            {
                velocity.y = jumpTakeOffSpeed * model.jumpModifier;
                jump = false;
            }
            else if (stopJump)
            {
                stopJump = false;
                if (velocity.y > 0)
                {
                    velocity.y = velocity.y * model.jumpDeceleration;
                }
            }

            if (move.x > 0.01f)
            {
                spriteRenderer.flipX = false;
                
            }
                
            else if (move.x < -0.01f)
                spriteRenderer.flipX = true;

            animator.SetBool("grounded", IsGrounded);
            animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);

            targetVelocity = move * maxSpeed;

           
        }

        public enum JumpState
        {
            Grounded,
            PrepareToJump,
            Jumping,
            InFlight,
            Landed
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "SpwonBox" )
            {
                this.transform.position = new Vector3(-12.12f, 0.48f, -2.96f);
                Cvar.transform.position = new Vector3(-5.645943f, 2.668464f, -12.96f);
                animator.SetBool("deth", true);
                FindObjectOfType<AudioManger>().Play("hurt");
                StartCoroutine("dethloop");

            }

            if (collision.gameObject.tag == "Spownbox2")
            {
                this.transform.position = new Vector3(3.57f, 4.08f, -2.96f);
                Cvar.transform.position = new Vector3(-5.645943f, 2.668464f, -12.96f);
                animator.SetBool("deth", true);
                FindObjectOfType<AudioManger>().Play("hurt");
                StartCoroutine("dethloop");

            }


        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                animator.SetBool("power", true);
                StartCoroutine("dethloop");
            }
        }
    }
}