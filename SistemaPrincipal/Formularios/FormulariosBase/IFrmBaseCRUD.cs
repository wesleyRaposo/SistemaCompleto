namespace SistemaPrincipal.Formularios.FormulariosBase
{
    interface IFrmBaseCRUD
    {
        protected virtual void LimparCampos() { }
        protected virtual void carregarCampos() { }
    }
}
