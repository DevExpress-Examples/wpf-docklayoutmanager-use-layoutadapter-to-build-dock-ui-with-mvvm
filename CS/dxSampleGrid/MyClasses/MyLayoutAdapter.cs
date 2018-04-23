using DevExpress.Xpf.Docking;

namespace dxSampleGrid {

    class MyLayoutAdapter : ILayoutAdapter {
        public string Resolve(DockLayoutManager owner, object item) {
            Person p = item as Person;
            if (p.IsTabbed) {
                return "TabbedGroup1";
            }
            if (p.IsFloat) {
                var floatGroups = owner.FloatGroups;
                FloatGroup fg;
                if (floatGroups.Count == 0) {
                    fg = new FloatGroup();
                    fg.Name = "NewFloatGroup1";
                    owner.FloatGroups.Add(fg);
                }
                else {
                    fg = floatGroups[0];
                }
                return fg.Name;
            }
            return p.ParentName;
        }
    }
}
