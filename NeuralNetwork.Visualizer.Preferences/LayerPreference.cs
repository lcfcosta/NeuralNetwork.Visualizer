﻿using NeuralNetwork.Visualizer.Contracts.Drawing.Core.Brushes;
using NeuralNetwork.Visualizer.Contracts.Drawing.Core.Pens;
using NeuralNetwork.Visualizer.Contracts.Preferences;

namespace NeuralNetwork.Visualizer.Preferences
{
   public class LayerPreference : ILayerPreference
   {
      private IBrush _background;
      public IBrush Background
      {
         get => _background ?? (_background = SolidBrush.Null);
         set => _background = value;
      }

      private Pen _border;
      public Pen Border
      {
         get => _border ?? (_border = Pen.Null);
         set => _border = value;
      }

      private Pen _borderSelected;
      public Pen BorderSelected
      {
         get => _borderSelected ?? (_borderSelected = Pen.Null);
         set => _borderSelected = value;
      }

      private IBrush _backgroundSelected;
      public IBrush BackgroundSelected
      {
         get => _backgroundSelected ?? (_backgroundSelected = SolidBrush.Null);
         set => _backgroundSelected = value;
      }

      private ILayerTitlePreference _title;
      public ILayerTitlePreference Title
      {
         get => _title ?? (_title = new LayerTitlePreference());
         set => _title = value;
      }
   }
}
