/*******************************************************************************
 * Copyright © 2016 SenseLue.Framework 版权所有
 * Author: SenseLue
 * Description: SenseLue快速开发平台
 * Website：http://www.SenseLue.cn
*********************************************************************************/
using System;

namespace SenseLue.Domain
{
    public interface ICreationAudited
    {
        string F_Id { get; set; }
        string F_CreatorUserId { get; set; }
        DateTime? F_CreatorTime { get; set; }
    }
}