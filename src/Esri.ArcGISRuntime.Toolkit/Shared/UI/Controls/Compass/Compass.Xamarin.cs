﻿// /*******************************************************************************
//  * Copyright 2012-2016 Esri
//  *
//  *  Licensed under the Apache License, Version 2.0 (the "License");
//  *  you may not use this file except in compliance with the License.
//  *  You may obtain a copy of the License at
//  *
//  *  http://www.apache.org/licenses/LICENSE-2.0
//  *
//  *   Unless required by applicable law or agreed to in writing, software
//  *   distributed under the License is distributed on an "AS IS" BASIS,
//  *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  *   See the License for the specific language governing permissions and
//  *   limitations under the License.
//  ******************************************************************************/

#if XAMARIN

using System;

namespace Esri.ArcGISRuntime.Toolkit.UI.Controls
{
    public partial class Compass
    {
        private double _heading;

        private double HeadingImpl
        {
            get { return _heading; }
            set
            {
                _heading = value;
                UpdateCompassRotation(true);
            }
        }

        private bool _autoHide;

        private bool AutoHideImpl
        {
            get { return _autoHide; }
            set
            {
                _autoHide = value;
            }
        }
    }
}
#endif