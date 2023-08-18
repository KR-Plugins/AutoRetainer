﻿using ECommons.GameHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRetainer.Modules.Voyage.Tasks
{
    internal static class TaskInteractWithNearestPanel
    {
        internal static void Enqueue(bool interact = true)
        {
            if (!VoyageUtils.Workshops.Contains(Svc.ClientState.TerritoryType))
            {
                TaskEnterWorkshop.EnqueueEnterWorkshop();
            }
            P.TaskManager.Enqueue(() =>
            {
                if(VoyageUtils.TryGetNearestVoyagePanel(out var obj) && Vector3.Distance(Player.Object.Position, obj.Position) > 4.25f)
                {
                    P.TaskManager.EnqueueImmediate(VoyageScheduler.Lockon);
                    P.TaskManager.EnqueueImmediate(VoyageScheduler.Approach);
                    P.TaskManager.EnqueueImmediate(VoyageScheduler.AutomoveOffPanel);
                }
            }, "ApproachPanelIfNeeded");
            if(interact) P.TaskManager.Enqueue(VoyageScheduler.InteractWithVoyagePanel);
        }
    }
}