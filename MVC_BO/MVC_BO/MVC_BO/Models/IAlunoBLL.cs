﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_BO.Models
{
    interface IAlunoBLL
    {
        List<Aluno> GetAlunos();
        void IncluirAluno(Aluno aluno);
        void AtualizarAluno(Aluno aluno);
    }
}
