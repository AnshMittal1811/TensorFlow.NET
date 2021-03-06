﻿using Keras.Layers;
using NumSharp;
using System;
using System.Collections.Generic;
using System.Text;
using Tensorflow.Data;
using Tensorflow.Keras.Initializers;

namespace Tensorflow.Keras.Engine
{
    public abstract class PreprocessingLayer : Layer
    {
        public abstract void adapt(Data.DatasetV1 data, bool reset_state = true);
    }

    public abstract class Combiner
    {
        public abstract dynamic compute(NDArray[] batch_values, dynamic accumulator = null);

        public abstract dynamic merge(dynamic[] accumulators);

        public abstract NDArray[] extract(dynamic accumulator);

        public abstract dynamic restore(Tensor output);

        public abstract string serialize(dynamic accumulator);

        public abstract dynamic deserialize(string encoded_accumulator);

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }

    public class CombinerPreprocessingLayer : PreprocessingLayer
    {
        public CombinerPreprocessingLayer(Combiner combiner)
        {
            throw new NotImplementedException();
        }

        private void _add_state_variable(string name, TensorShape shape, string dtype, Initializer initializer= null, string partitioner= null, bool? use_resource= null) => throw new NotImplementedException();

        private Dictionary<string, NDArray> _restore_updates() => throw new NotImplementedException();

        private bool _dataset_is_infinite(DatasetV1 dataset) => throw new NotImplementedException();

        private dynamic _get_dataset_iterator(DatasetV1 dataset) => throw new NotImplementedException();

        private void _set_state_variables(Dictionary<string, Tensor> updates) => throw new NotImplementedException();

        public override void adapt(DatasetV1 data, bool reset_state = true)
        {
            throw new NotImplementedException();
        }
    }
}
