﻿/*
 * Copyright © 2017 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * 
 * EDDiscovery is not affiliated with Frontier Developments plc.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedControls
{
    public interface ThemeableForms             // Extended controls use this if they want to be themed
    {
        bool ApplyToForm(System.Windows.Forms.Form form, System.Drawing.Font fnt = null);   // null means use standard one
        void ApplyToControls(System.Windows.Forms.Control parent, System.Drawing.Font fnt = null);
        System.Drawing.Color TextBlockColor { get; set; }
        string FontName { get; set; }
        bool WindowsFrame { get; set; }
        System.Drawing.Icon MessageBoxWindowIcon { get; set; }
    }

    public static class ThemeableFormsInstance
    {
        static public ThemeableForms Instance { get; set; }
    }
}
