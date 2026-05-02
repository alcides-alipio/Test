using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EaseStay.Core
{
    internal class Utils
    {
        public static void FlashBorders(params dynamic[] controls)
        {
            int ticks = 0;

            var states = controls.Select(c => new
            {
                Control = c,
                Original = c.BorderColor
            }).ToList();

            var timer = new Timer();
            timer.Interval = 200;

            timer.Tick += (sender, args) =>
            {
                foreach (var state in states)
                {
                    state.Control.BorderColor =
                        state.Control.BorderColor == Color.LightCoral
                            ? state.Original
                            : Color.LightCoral;
                }

                ticks++;

                if (ticks >= 4)
                {
                    timer.Stop();

                    foreach (var state in states)
                    {
                        state.Control.BorderColor = state.Original;
                    }
                }
            };

            timer.Start();
        }


        /// <summary>
        /// Associa ou remove um manipulador de evento para todos os controles do tipo 
        /// <typeparamref name="T"/> dentro de um contêiner, percorrendo a hierarquia 
        /// de forma recursiva.
        /// </summary>
        /// <typeparam name="T">
        /// Tipo de controle alvo que receberá o evento.
        /// </typeparam>
        /// <param name="parent">
        /// Controle raiz cuja árvore de filhos será percorrida.
        /// </param>
        /// <param name="subscribe">
        /// Ação responsável por associar o manipulador ao evento desejado.
        /// </param>
        /// <param name="unsubscribe">
        /// Ação responsável por remover o manipulador do evento desejado.
        /// </param>
        /// <param name="enable">
        /// Se <c>true</c>, associa o evento; se <c>false</c>, remove.
        /// </param>
        /// <remarks>
        /// Evite o uso de expressões lambda anônimas diretamente na inscrição,
        /// pois sua remoção posterior pode não ser possível sem manter referência.
        /// </remarks>
        public static void SetControlEvents<T>(
            Control parent,
            Action<T> subscribe,
            Action<T> unsubscribe,
            bool enable
        ) where T : Control
        {
            foreach (Control control in parent.Controls)
            {
                if (control is T target)
                {
                    if (enable)
                        subscribe(target);
                    else
                        unsubscribe(target);
                }

                if (control.HasChildren)
                {
                    SetControlEvents(control, subscribe, unsubscribe, enable);
                }
            }
        }
    }
}
