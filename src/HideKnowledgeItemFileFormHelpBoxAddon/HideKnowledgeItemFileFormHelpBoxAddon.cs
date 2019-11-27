using SwissAcademic.Citavi.Shell;
using System;

namespace HideKnowledgeItemFileFormHelpBox
{
    public class HideKnowledgeItemFileFormHelpBoxAddon : CitaviAddOn<KnowledgeItemFileForm>
    {
        #region Methods

        public override void OnHostingFormLoaded(KnowledgeItemFileForm knowledgeItemFileForm)
        {
            try
            {
                knowledgeItemFileForm.HelpBox.Hide();
            }
            catch (Exception){}

            base.OnHostingFormLoaded(knowledgeItemFileForm);
        }

        #endregion
    }
}