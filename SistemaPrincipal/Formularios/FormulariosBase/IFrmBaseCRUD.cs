namespace SistemaPrincipal.Formularios.FormulariosBase
{
    interface IFrmBaseCRUD
    {
        protected virtual void LimparCampos() { }

        protected virtual void CarregarCampos() { }

        protected virtual void DefinirStatusDeOpearcao() { }


        protected virtual bool PodeGravar() { return true; }
        protected virtual void Gravar() { }

        protected virtual bool PodeExcluir() { return true; }
        protected virtual void Excluir() { }
    }
}
