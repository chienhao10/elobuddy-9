﻿using EloBuddy;
using EloBuddy.SDK;
using System;
using System.Diagnostics;
using Humanizer = PartyMorg.Config.Settings.Humanizer;
using Settings = PartyMorg.Config.Settings.Harass;

namespace PartyMorg.Modes
{
    public sealed class Harass : ModeBase
    {
        public override bool ShouldBeExecuted()
        {
            /*if (Settings.AutoHarass && Player.Instance.ManaPercent >= Settings.AutoHarassManaPercent)
            {
                var target = GetTarget(W, DamageType.Magical);

                if (target != null)
                {
                    W.Cast(target);
                }
            }*/

            return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Harass);
        }

        public static Stopwatch stopwatch = new Stopwatch();

        public override void Execute()
        {
            var target = GetTarget(Q, DamageType.Magical);

            PredictionResult pred;

            if (target != null && target.IsTargetable && !target.HasBuffOfType(BuffType.SpellImmunity) && Settings.UseQ && !target.IsDead && Player.Instance.IsInRange(target, Q.Range))
            {
                pred = Q.GetPrediction(target);

                if (Humanizer.QCastDelayEnabled)
                {
                    if (Humanizer.QRndmDelay)
                    {
                        stopwatch.Start();

                        if (stopwatch.ElapsedMilliseconds >= new Random().Next(250, Humanizer.QCastDelay))
                        {
                            if (pred.HitChancePercent >= Settings.QMinHitChance)
                            {
                                Q.Cast(pred.CastPosition);
                            }

                            stopwatch.Reset();
                        }
                    }
                    else
                    {
                        stopwatch.Start();

                        if (stopwatch.ElapsedMilliseconds >= Humanizer.QCastDelay)
                        {
                            if (pred.HitChancePercent >= Settings.QMinHitChance)
                            {
                                Q.Cast(pred.CastPosition);
                            }

                            stopwatch.Reset();
                        }
                    }
                }
                else
                {
                    if (pred.HitChancePercent >= Settings.QMinHitChance)
                    {
                        Q.Cast(pred.CastPosition);
                    }
                }
            }

            if (Settings.WImmobileOnly)
            {
                if (target != null && target.IsTargetable && !target.HasBuffOfType(BuffType.SpellImmunity) && Settings.UseW && !target.IsDead && Player.Instance.IsInRange(target, W.Range) && Immobile(target))
                {
                    pred = W.GetPrediction(target);

                    W.Cast(pred.CastPosition);
                }
            }
            else
            {
                if (target != null && target.IsTargetable && !target.HasBuffOfType(BuffType.SpellImmunity) && Settings.UseW && !target.IsDead && Player.Instance.IsInRange(target, W.Range))
                {
                    pred = W.GetPrediction(target);

                    if (Settings.UseQBeforeW)
                    {
                        if (Q.IsOnCooldown)
                        {
                            W.Cast(pred.CastPosition);
                        }
                    }
                    else
                    {
                        W.Cast(pred.CastPosition);
                    }
                }
            }
        }
    }
}
