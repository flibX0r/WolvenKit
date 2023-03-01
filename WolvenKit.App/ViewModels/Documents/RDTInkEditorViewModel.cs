using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;
public partial class RDTInkEditorViewModel : RedDocumentTabViewModel
{
    public inkWidgetLibraryResource library;

    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

    public RDTInkEditorViewModel(inkWidgetLibraryResource lib, RedDocumentViewModel file)
        : base(file, "Ink Editor") => library = lib;
}
