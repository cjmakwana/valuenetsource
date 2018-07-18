using System;
using System.Collections.Generic;
using System.Text;
using TurtleAttack.Domain.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace TurtleAttack.Domain.Services
{
    public class PanelService
    {
        private List<Panel> _storedPanels;

        private static PanelService _instance;
        public static PanelService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelService();
                return _instance;
            }
        }

        private PanelService()
        {
            _storedPanels = new List<Panel>();
        }

        public IEnumerable<Panel> GetAll()
        {
            return _storedPanels.ToArray();
        }

        public Panel Get(string id)
        {
            return _storedPanels.FirstOrDefault(p => string.Compare(p.MacId, id, true) == 0);
        }

        public bool Add(Panel panel)
        {
            _storedPanels.Add(panel);
            return true;
        }

        public bool Remove(string id)
        {
            var toRemove = Get(id);
            return _storedPanels.Remove(toRemove);
        }

        public bool Exists(string id)
        {
            return _storedPanels.Exists(p => string.Compare(id, p.MacId, true) == 0);
        }

        public bool Update(Panel panel)
        {
            return Remove(panel.MacId) && Add(panel);
        }
    }
}
