﻿using System.Collections.Generic;
using AllReady.Areas.Admin.ViewModels.Task;
using MediatR;

namespace AllReady.Areas.Admin.Features.Tasks
{
    public class TaskListQuery : IRequest<IEnumerable<TaskSummaryViewModel>>
    {
        public int EventId { get; set; }
    }
}
